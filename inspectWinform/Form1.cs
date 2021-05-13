using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inspectWinform
{
    public partial class Form1 : Form
    {
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
            //取消关闭安妮
            this.ControlBox = false;
            //新建Socket连接
            inspectConnectInfo = new ConnectInfo();
            plcConnectArr[0] = new ConnectInfo();
            plcConnectArr[1] = new ConnectInfo();
            plcConnectArr[2] = new ConnectInfo();

            //给PLC连接地址赋值
            if (isEmpty(trigger1.Text) && isEmpty(result1.Text))
            {
                cam1CmdAds = "D" + trigger1.Text + " 01";
                cam1ResAds = "D" + result1.Text + " 01";
            }

            if (isEmpty(trigger2.Text) && isEmpty(result2.Text))
            {
                cam2CmdAds = "D" + trigger2.Text + " 01";
                cam2ResAds = "D" + result2.Text + " 01";
            }

            if (isEmpty(trigger3.Text) && isEmpty(result3.Text))
            {
                cam3CmdAds = "D" + trigger3.Text + " 01";
                cam3ResAds = "D" + result3.Text + " 01";
            }
            //connectAllcon();
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
            if (inspectSocket == null & !isEmpty(inspectIp.Text) & !isEmpty(inspectPort.Text))
            {
                inspectConnectInfo.ip = inspectIp.Text;
                inspectConnectInfo.port = int.Parse(inspectPort.Text);
                inspectSocket = InspectUtils.connectToTarget(inspectConnectInfo.ip, inspectConnectInfo.port);
                if (inspectSocket != null)
                {
                    flag = true;
                }
            }

            if (plcSocket1 == null & !isEmpty(plcIp1.Text) & !isEmpty(plcPort1.Text))
            {
                plcConnectArr[0].ip = plcIp1.Text;
                plcConnectArr[0].port = int.Parse(plcPort1.Text);
                plcSocket1 = InspectUtils.connectToTarget(plcConnectArr[0].ip, plcConnectArr[0].port);
                if (plcSocket1 != null)
                {
                    flag = true;
                }
            }

            if (plcSocket2 == null & !isEmpty(plcIp2.Text) & !isEmpty(plcPort2.Text))
            {
                plcConnectArr[1].ip = plcIp2.Text;
                plcConnectArr[1].port = int.Parse(plcPort2.Text);
                plcSocket2 = InspectUtils.connectToTarget(plcConnectArr[1].ip, plcConnectArr[1].port);
                if (plcSocket2 != null)
                {
                    flag = true;
                }
            }

            if (plcSocket3 == null & !isEmpty(plcIp3.Text) & !isEmpty(plcPort3.Text))
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

        #region 点击连接按钮

        private void connectAll_Click(object sender, EventArgs e)
        {
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

        #region 相机触发测试

        private void cmdCam1_Click(object sender, EventArgs e)
        {
            string str = "c1;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            //var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
        }

        private void cmdCam2_Click(object sender, EventArgs e)
        {
            string str = "c2;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            //var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
        }

        private void cmdCam3_Click(object sender, EventArgs e)
        {
            string str = "c3;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            //var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
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
                plcPort1.ReadOnly = true;
                plcIp2.ReadOnly = true;
                plcPort2.ReadOnly = true;
                plcIp3.ReadOnly = true;
                plcPort3.ReadOnly = true;
            }
            else
            {
                inspectIp.ReadOnly = false;
                inspectPort.ReadOnly = false;
                plcIp1.ReadOnly = false;
                plcPort1.ReadOnly = false;
                plcIp2.ReadOnly = false;
                plcPort2.ReadOnly = false;
                plcIp3.ReadOnly = false;
                plcPort3.ReadOnly = false;
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
    }
}