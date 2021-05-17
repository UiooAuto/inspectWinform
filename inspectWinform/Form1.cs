using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace inspectWinform
{
    public partial class Form1 : Form
    {
        private AllConnectData allConnectData = new AllConnectData();

        string filePath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")) +
                          "\\saveData.JSON"; //xml文件地址

        private string inspectPath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")) +
                                     "\\startInspect.bat";
        //inspect和plc的连接信息
        ConnectInfo inspectConnectInfo;
        ConnectInfo[] plcConnectArr = new ConnectInfo[3];

        //用于存放读取结果的数组
        public byte[] resByteArr = new byte[1024];

        //用于通信的Socket
        Socket inspectSocket;
        Socket plcSocket1;
        Socket plcSocket2;
        Socket plcSocket3;

        //用于多线程执行的对象
        static Work work1 = new Work();
        static Work work2 = new Work();
        static Work work3 = new Work();

        //准备plc所用的各种地址
        string cam1CmdAds;
        string cam1ResAds;
        string cam2CmdAds;
        string cam2ResAds;
        string cam3CmdAds;
        string cam3ResAds;

        bool connectStatus = false;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        #region 初始化

        /// <summary>
        /// 窗口初始化
        /// </summary>
        public void init()
        {
            bool inspectRun = false;
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals("iworks"))
                {
                    inspectRun = true;
                }
            }

            if (!inspectRun)
            {
                Process.Start(inspectPath);
            }
            //取消关闭安妮
            this.ControlBox = false;
            //新建Socket连接
            inspectConnectInfo = new ConnectInfo();
            plcConnectArr[0] = new ConnectInfo();
            plcConnectArr[1] = new ConnectInfo();
            plcConnectArr[2] = new ConnectInfo();

            //读取前一次的连接数据
            readSaveData();

            inspectIp.Text = allConnectData.inspectIp;
            inspectPort.Text = allConnectData.inspectPort;
            plcIp1.Text = allConnectData.plcIp1;
            plcIp2.Text = allConnectData.plcIp2;
            plcIp3.Text = allConnectData.plcIp3;
            plcPort1.Text = allConnectData.plcPort1;
            plcPort2.Text = allConnectData.plcPort2;
            plcPort3.Text = allConnectData.plcPort3;

            trigger1.Text = allConnectData.cam1CmdAds;
            trigger2.Text = allConnectData.cam2CmdAds;
            trigger3.Text = allConnectData.cam3CmdAds;
            result1.Text = allConnectData.cam1ResAds;
            result2.Text = allConnectData.cam2ResAds;
            result3.Text = allConnectData.cam3ResAds;

            //给PLC连接地址赋值
            if (!isEmpty(trigger1.Text) && !isEmpty(result1.Text))
            {
                cam1CmdAds = "D" + trigger1.Text + " 01";
                cam1ResAds = "D" + result1.Text + " 01";
            }

            if (!isEmpty(trigger2.Text) && !isEmpty(result2.Text))
            {
                cam2CmdAds = "D" + trigger2.Text + " 01";
                cam2ResAds = "D" + result2.Text + " 01";
            }

            if (!isEmpty(trigger3.Text) && !isEmpty(result3.Text))
            {
                cam3CmdAds = "D" + trigger3.Text + " 01";
                cam3ResAds = "D" + result3.Text + " 01";
            }
        }

        #endregion

        #region 点击连接按钮

        private void connectAll_Click(object sender, EventArgs e)
        {
            //给PLC连接地址赋值
            if (!isEmpty(trigger1.Text) && !isEmpty(result1.Text))
            {
                cam1CmdAds = "D" + trigger1.Text + " 01";
                cam1ResAds = "D" + result1.Text + " 01";
            }
            else
            {
                cam1CmdAds = null;
                cam1ResAds = null;
            }

            if (!isEmpty(trigger2.Text) && !isEmpty(result2.Text))
            {
                cam2CmdAds = "D" + trigger2.Text + " 01";
                cam2ResAds = "D" + result2.Text + " 01";
            }
            else
            {
                cam2CmdAds = null;
                cam2ResAds = null;
            }

            if (!isEmpty(trigger3.Text) && !isEmpty(result3.Text))
            {
                cam3CmdAds = "D" + trigger3.Text + " 01";
                cam3ResAds = "D" + result3.Text + " 01";
            }
            else
            {
                cam3CmdAds = null;
                cam3ResAds = null;
            }

            //当在有链接的时候点击，需要关闭所有连接
            if ((inspectSocket != null && inspectSocket.Connected)
                || plcSocket1 != null && plcSocket1.Connected
                || plcSocket2 != null && plcSocket2.Connected
                || plcSocket3 != null && plcSocket3.Connected)
            {
                closeAllSocket();
                connectAll.Text = "连接";
                connectAll.BackColor = Color.Silver;
            }
            else
            {
                connectAllcon();
                startWork();
            }

            enTextBoxs();
        }

        #endregion

        #region 启动程序主要功能

        /// <summary>
        /// 启动程序主要功能
        /// </summary>
        public void startWork()
        {
            //仅当对应plc有连接的时候，才开启线程
            if (plcSocket1 != null)
            {
                work1.plcSocket = plcSocket1;
                work1.localSocket = inspectSocket;
                work1.camCmdAds = cam1CmdAds;
                work1.camResAds = cam1ResAds;

                work1.plc1CmdAds = cam1CmdAds;
                work1.plc2CmdAds = cam2CmdAds;
                work1.plc3CmdAds = cam3CmdAds;
                work1.san = true;
                Thread thread1 = new Thread(new ThreadStart(work1.go));
                thread1.Name = "cam1";
                thread1.Start();
            }

            if (plcSocket2 != null)
            {
                work2.plcSocket = plcSocket2;
                work2.localSocket = inspectSocket;
                work2.camCmdAds = cam2CmdAds;
                work2.camResAds = cam2ResAds;

                work2.plc1CmdAds = cam1CmdAds;
                work2.plc2CmdAds = cam2CmdAds;
                work2.plc3CmdAds = cam3CmdAds;
                work2.san = true;
                Thread thread2 = new Thread(new ThreadStart(work2.go));
                thread2.Name = "cam2";
                thread2.Start();
            }

            if (plcSocket1 != null)
            {
                work3.plcSocket = plcSocket3;
                work3.localSocket = inspectSocket;
                work3.camCmdAds = cam3CmdAds;
                work3.camResAds = cam3ResAds;

                work3.plc1CmdAds = cam1CmdAds;
                work3.plc2CmdAds = cam2CmdAds;
                work3.plc3CmdAds = cam3CmdAds;
                work3.san = true;
                Thread thread3 = new Thread(new ThreadStart(work3.go));
                thread3.Name = "cam3";
                thread3.Start();
            }
        }

        #endregion

        #region 连接所有连接

        /// <summary>
        /// 建立所有连接
        /// </summary>
        public void connectAllcon()
        {
            //用于标识是否有连接建立成功
            bool flag = false;
            //只有在有连接参数的时候才连接
            if (inspectSocket == null && !isEmpty(inspectIp.Text) && !isEmpty(inspectPort.Text))
            {
                inspectConnectInfo.ip = inspectIp.Text;
                inspectConnectInfo.port = int.Parse(inspectPort.Text);
                inspectSocket = InspectUtils.connectToTarget(inspectConnectInfo.ip, inspectConnectInfo.port);
                if (inspectSocket != null)
                {
                    flag = true;
                }
            }

            if (plcSocket1 == null && !isEmpty(plcIp1.Text) && !isEmpty(plcPort1.Text) && !isEmpty(trigger1.Text) &&
                !isEmpty(result1.Text))
            {
                plcConnectArr[0].ip = plcIp1.Text;
                plcConnectArr[0].port = int.Parse(plcPort1.Text);
                plcSocket1 = InspectUtils.connectToTarget(plcConnectArr[0].ip, plcConnectArr[0].port);
                if (plcSocket1 != null)
                {
                    flag = true;
                }
            }

            if (plcSocket2 == null && !isEmpty(plcIp2.Text) && !isEmpty(plcPort2.Text) && !isEmpty(trigger2.Text) &&
                !isEmpty(result2.Text))
            {
                plcConnectArr[1].ip = plcIp2.Text;
                plcConnectArr[1].port = int.Parse(plcPort2.Text);
                plcSocket2 = InspectUtils.connectToTarget(plcConnectArr[1].ip, plcConnectArr[1].port);
                if (plcSocket2 != null)
                {
                    flag = true;
                }
            }

            if (plcSocket3 == null && !isEmpty(plcIp3.Text) && !isEmpty(plcPort3.Text) && !isEmpty(trigger3.Text) &&
                !isEmpty(result3.Text))
            {
                plcConnectArr[2].ip = plcIp3.Text;
                plcConnectArr[2].port = int.Parse(plcPort3.Text);
                plcSocket3 = InspectUtils.connectToTarget(plcConnectArr[2].ip, plcConnectArr[2].port);
                if (plcSocket3 != null)
                {
                    flag = true;
                }
            }

            if (flag)
            {
                connectAll.Text = "关闭连接";
                connectAll.BackColor = Color.LimeGreen;
                connectStatus = true;
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        #endregion

        #region 字符串非空

        /// <summary>
        /// 判断字符串非空
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool isEmpty(string str)
        {
            if (str.Length != 0 & str != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region 相机触发测试

        private void cmdCam1_Click(object sender, EventArgs e)
        {
            string str = "c1;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
            if (receiveData == "1")
            {
                setPlcCmd(plcSocket1, cam1ResAds, " 0001\r\n");
            }
            else if (receiveData == "2")
            {
                setPlcCmd(plcSocket1, cam1ResAds, " 0002\r\n");
            }
        }

        private void cmdCam2_Click(object sender, EventArgs e)
        {
            string str = "c2;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
            if (receiveData == "1")
            {
                setPlcCmd(plcSocket2, cam2ResAds, " 0001\r\n");
            }
            else if (receiveData == "2")
            {
                setPlcCmd(plcSocket2, cam2ResAds, " 0002\r\n");
            }
        }

        private void cmdCam3_Click(object sender, EventArgs e)
        {
            string str = "c3;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
            if (receiveData == "1")
            {
                setPlcCmd(plcSocket3, cam3ResAds, " 0001\r\n");
            }
            else if (receiveData == "2")
            {
                setPlcCmd(plcSocket3, cam3ResAds, " 0002\r\n");
            }
        }

        #endregion

        #region 关闭所有连接

        public void closeAllSocket()
        {
            if (inspectSocket != null)
            {
                InspectUtils.shutDownConnect(inspectSocket);
                inspectSocket.Close();
                inspectSocket = null;
            }

            if (plcSocket1 != null)
            {
                InspectUtils.shutDownConnect(plcSocket1);
                plcSocket1.Close();
                plcSocket1 = null;
            }

            if (plcSocket2 != null)
            {
                InspectUtils.shutDownConnect(plcSocket2);
                plcSocket2.Close();
                plcSocket2 = null;
            }

            if (plcSocket3 != null)
            {
                InspectUtils.shutDownConnect(plcSocket3);
                plcSocket3.Close();
                plcSocket3 = null;
            }

            connectStatus = false;
        }

        #endregion

        #region 根据连接状态禁用或启用输入框

        public void enTextBoxs()
        {
            if (connectStatus)
            {
                inspectIp.ReadOnly = true;
                inspectPort.ReadOnly = true;
                plcIp1.ReadOnly = true;
                plcIp2.ReadOnly = true;
                plcIp3.ReadOnly = true;
                plcPort1.ReadOnly = true;
                plcPort2.ReadOnly = true;
                plcPort3.ReadOnly = true;

                trigger1.ReadOnly = true;
                trigger2.ReadOnly = true;
                trigger3.ReadOnly = true;
                result1.ReadOnly = true;
                result2.ReadOnly = true;
                result3.ReadOnly = true;
            }
            else
            {
                inspectIp.ReadOnly = false;
                inspectPort.ReadOnly = false;
                plcIp1.ReadOnly = false;
                plcIp2.ReadOnly = false;
                plcIp3.ReadOnly = false;
                plcPort1.ReadOnly = false;
                plcPort2.ReadOnly = false;
                plcPort3.ReadOnly = false;

                trigger1.ReadOnly = false;
                trigger2.ReadOnly = false;
                trigger3.ReadOnly = false;
                result1.ReadOnly = false;
                result2.ReadOnly = false;
                result3.ReadOnly = false;
            }
        }

        #endregion

        #region 退出按钮

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult
                TS = MessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //弹出提示是否退出
            if (TS == DialogResult.Yes)
            {
                closeAllSocket();
                System.Environment.Exit(0);
            }
        }

        #endregion

        #region 保存连接数据

        public void saveDatas()
        {
            allConnectData.inspectIp = inspectIp.Text;
            allConnectData.inspectPort = inspectPort.Text;
            allConnectData.plcIp1 = plcIp1.Text;
            allConnectData.plcIp2 = plcIp2.Text;
            allConnectData.plcIp3 = plcIp3.Text;
            allConnectData.plcPort1 = plcPort1.Text;
            allConnectData.plcPort2 = plcPort2.Text;
            allConnectData.plcPort3 = plcPort3.Text;

            allConnectData.cam1CmdAds = trigger1.Text;
            allConnectData.cam2CmdAds = trigger2.Text;
            allConnectData.cam3CmdAds = trigger3.Text;
            allConnectData.cam1ResAds = result1.Text;
            allConnectData.cam2ResAds = result2.Text;
            allConnectData.cam3ResAds = result3.Text;

            File.WriteAllText(filePath, JsonConvert.SerializeObject(allConnectData));
        }

        public void readSaveData()
        {
            if (File.Exists(filePath))
            {
                string readAllText = File.ReadAllText(filePath, Encoding.UTF8);
                if (!isEmpty(readAllText))
                {
                    try
                    {
                        allConnectData = JsonConvert.DeserializeObject<AllConnectData>(readAllText);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("读取存档失败");
                    }
                }
            }
            else
            {
                FileStream fileStream = File.Create(filePath);
                fileStream.Close();
            }
        }

        #endregion

        #region 给plc发送信息

        private string setPlcCmd(Socket socket, string plcAddress, string setResult)
        {
            string rtn = InspectUtils.sendCmdToTarget(socket, "01WWR" + plcAddress + setResult + "\r\n");
            MessageBox.Show("01WWR" + plcAddress + setResult + "\r\n");
            return rtn;
        }

        #endregion

        private void save_Click(object sender, EventArgs e)
        {
            saveDatas();
        }

        private void savePath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "/select,"+filePath);
        }
    }
}