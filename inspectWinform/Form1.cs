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
        //用于保存连接数据的对象
        private AllConnectData allConnectData = new AllConnectData();

        string filePath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")) +
                          "\\saveData.JSON"; //xml文件地址

        private string inspectPath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")) +
                                     "\\startInspect.bat"; //批处理文件启动inspect路径

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

        //用于判断连接状态
        bool connectStatus = false;

        public Form1()
        {
            InitializeComponent();
            init(); //初始化流程
        }

        #region 初始化

        /// <summary>
        /// 窗口初始化
        /// 检测Inspect是否已启动
        /// 取消系统自带关闭按钮
        /// 新建socket
        /// 读取保存好的文件中的数据
        /// 把连接参数恢复到窗口中
        /// 创建自动连接窗口，等待倒计时窗口结束后获取是否需要自动连接
        /// 如需自动连接，则自动连接
        /// </summary>
        public void init()
        {
            //查询inspect是否已启动，未启动则自动启动
            bool inspectRun = false;

            //取消关闭按钮
            this.ControlBox = false;
            //新建Socket连接
            inspectConnectInfo = new ConnectInfo();
            plcConnectArr[0] = new ConnectInfo();
            plcConnectArr[1] = new ConnectInfo();
            plcConnectArr[2] = new ConnectInfo();

            //读取前一次的连接数据
            readSaveData();

            //界面中已保存值恢复
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

            autoConTimeSet.Text = allConnectData.autoConnTime;
            
            conn1En.Checked = allConnectData.con1En;
            conn2En.Checked = allConnectData.con2En;
            conn3En.Checked = allConnectData.con3En;

            //创建窗口对象
            AutoConnectForm autoConnectForm = new AutoConnectForm();
            //如果文件中没有保存等待时间，则默认为10
            if (isEmpty(allConnectData.autoConnTime))
            {
                autoConnectForm.autoConnTime = "10";
            }
            else
            {
                autoConnectForm.autoConnTime = allConnectData.autoConnTime;
            }

            //运行窗口，阻塞主体程序运行
            autoConnectForm.ShowDialog();

            if (autoConnectForm.autoConn)
            {
                //拉取进程列表
                Process[] processes = Process.GetProcesses();
                //查找有没有inspect的进程
                foreach (Process process in processes)
                {
                    if (process.ProcessName.Equals("iworks"))
                    {
                        inspectRun = true;
                    }
                }

                //没有找到说明inspect没启动，启动inspect
                if (!inspectRun)
                {
                    Process.Start(inspectPath);
                    
                    if (isEmpty(allConnectData.delayStartInspect))
                    {
                        Thread.Sleep(5000);
                        autoStartInspectTime.Text = "5";
                    }
                    else
                    {
                        autoStartInspectTime.Text = allConnectData.delayStartInspect;
                        Thread.Sleep(int.Parse(allConnectData.delayStartInspect)*1000);
                    }
                }
                //开始连接
                startConnect();
            }
        }

        #endregion

        #region 点击连接按钮

        private void connectAll_Click(object sender, EventArgs e)
        {
            startConnect();
        }

        #endregion

        #region 连接功能

        public void startConnect()
        {
            //给PLC连接地址赋值,如果有一个没填写都认为是空
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

            //有任何一个通信是已连接的，就需要关闭连接
            if ((inspectSocket != null && inspectSocket.Connected)
                || plcSocket1 != null && plcSocket1.Connected
                || plcSocket2 != null && plcSocket2.Connected
                || plcSocket3 != null && plcSocket3.Connected)
            {
                closeAllSocket(); //关闭所有连接
                connectAll.Text = "连接";
                connectAll.BackColor = Color.Silver;
            }
            else
            {
                //否则建立全部连接
                connectAllcon();
                //开始工作
                startWork();
            }

            //根据连接状态使画面上的输入框只读
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
                //获取连接参数
                inspectConnectInfo.ip = inspectIp.Text;
                inspectConnectInfo.port = int.Parse(inspectPort.Text);
                //建立连接
                inspectSocket = InspectUtils.connectToTarget(inspectConnectInfo.ip, inspectConnectInfo.port);
                //inspectSocket.SendTimeout = 500;
                //连接状态更新
                if (inspectSocket != null)
                {
                    flag = true;
                }
            }

            //PLC连接需要额外判断复选框是否勾选
            if (conn1En.Checked && plcSocket1 == null && !isEmpty(plcIp1.Text) && !isEmpty(plcPort1.Text) &&
                !isEmpty(trigger1.Text) &&
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

            if (conn2En.Checked && plcSocket2 == null && !isEmpty(plcIp2.Text) && !isEmpty(plcPort2.Text) &&
                !isEmpty(trigger2.Text) &&
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

            if (conn3En.Checked && plcSocket3 == null && !isEmpty(plcIp3.Text) && !isEmpty(plcPort3.Text) &&
                !isEmpty(trigger3.Text) &&
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

            //判断标志位状态，没有发生更改，说明一个连接都没有建立
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
            if (!string.IsNullOrEmpty(str))
            {
                return false;
            }

            return true;
        }

        #endregion

        #region 相机触发测试

        /// <summary>
        /// 界面上的相相机触发按钮
        /// 在已连接状态下点击即可使对应相机拍照
        /// 可以用于测试相机通信
        /// 拍照成功后会弹窗显示返回的值，可据此判断连接程序通信格式是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCam1_Click(object sender, EventArgs e)
        {
            string str = "c1;";
            MessageBox.Show("向" + inspectIp.Text + ":" + inspectPort.Text + "发送消息：" + str);
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
            MessageBox.Show("从" + inspectIp.Text + ":" + inspectPort.Text + "接收到消息：" + receiveData);
            if (receiveData == "1")
            {
                setPlcCmd(plcSocket1, cam1ResAds, " 0001\r\n");
                setPlcCmd(plcSocket1, cam1CmdAds, " 0000\r\n");
            }
            else if (receiveData == "2")
            {
                setPlcCmd(plcSocket1, cam1ResAds, " 0002\r\n");
                setPlcCmd(plcSocket1, cam1CmdAds, " 0000\r\n");
            }
        }

        private void cmdCam2_Click(object sender, EventArgs e)
        {
            string str = "c2;";
            MessageBox.Show("向" + inspectIp.Text + ":" + inspectPort.Text + "发送消息：" + str);
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
            MessageBox.Show("从" + inspectIp.Text + ":" + inspectPort.Text + "接收到消息：" + receiveData);
            if (receiveData == "1")
            {
                setPlcCmd(plcSocket2, cam2ResAds, " 0001\r\n");
                setPlcCmd(plcSocket2, cam2CmdAds, " 0000\r\n");
            }
            else if (receiveData == "2")
            {
                setPlcCmd(plcSocket2, cam2ResAds, " 0002\r\n");
                setPlcCmd(plcSocket2, cam2CmdAds, " 0000\r\n");
            }
        }

        private void cmdCam3_Click(object sender, EventArgs e)
        {
            string str = "c3;";
            InspectUtils.sendCmdToTarget(inspectSocket, str);
            MessageBox.Show("向" + inspectIp.Text + ":" + inspectPort.Text + "发送消息：" + str);
            var receiveData = InspectUtils.receiveDataFromTarget(inspectSocket, resByteArr);
            MessageBox.Show("从" + inspectIp.Text + ":" + inspectPort.Text + "接收到消息：" + receiveData);
            if (receiveData == "1")
            {
                setPlcCmd(plcSocket3, cam3ResAds, " 0001\r\n");
                setPlcCmd(plcSocket3, cam3CmdAds, " 0000\r\n");
            }
            else if (receiveData == "2")
            {
                setPlcCmd(plcSocket3, cam3ResAds, " 0002\r\n");
                setPlcCmd(plcSocket3, cam3CmdAds, " 0000\r\n");
            }
        }

        #endregion

        #region 关闭所有连接

        /// <summary>
        /// 判断连接是否存在
        /// 存在则关闭连接，释放资源，最后使Socket为null
        /// </summary>
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

        //退出前会关闭所有连接
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

        #region 保存、读取连接数据

        /// <summary>
        /// 获取全部需要保存的参数，放在预先建立好的对象中
        /// 把对象转换为JSON的字符串格式，再整体写入
        /// </summary>
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

            allConnectData.autoConnTime = autoConTimeSet.Text;

            allConnectData.con1En = conn1En.Checked;
            allConnectData.con2En = conn2En.Checked;
            allConnectData.con3En = conn3En.Checked;

            allConnectData.delayStartInspect = autoStartInspectTime.Text;

            File.WriteAllText(filePath, JsonConvert.SerializeObject(allConnectData));
        }

        /// <summary>
        /// 读取指定位置的文件，将内容按JSON格式转换为对象
        /// </summary>
        public void readSaveData()
        {
            //文件存在则进行读取，否则创建新文件
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

        /// <summary>
        /// 本程序只用于测试按钮的通信，正式通信程序在Work的类中
        /// </summary>
        /// <param name="socket">Socket</param>
        /// <param name="plcAddress">PLC的结果地址</param>
        /// <param name="setResult">发送的结果内容</param>
        /// <returns></returns>
        private void setPlcCmd(Socket socket, string plcAddress, string setResult)
        {
            string rtn1 = InspectUtils.sendCmdToTarget(socket, "01WWR" + plcAddress + setResult + "\r\n");
            MessageBox.Show("给PLC发送：01WWR" + plcAddress + setResult + "\r\n");
        }

        #endregion

        #region 保存参数按钮

        //执行保存参数操作
        private void save_Click(object sender, EventArgs e)
        {
            saveDatas();
        }

        #endregion

        #region 打开参数文件位置

        //点击打开文件所在位置按钮，使用文件管理器打开路径并将光标对准文件
        private void savePath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "/select," + filePath);
        }

        #endregion

        #region 用过复选框选择需要的连接

        //复选框没有选的连接将会被禁用
        private void conn1En_CheckedChanged(object sender, EventArgs e)
        {
            if (!conn1En.Checked)
            {
                plcIp1.Enabled = false;
                plcPort1.Enabled = false;
                trigger1.Enabled = false;
                result1.Enabled = false;
            }
            else
            {
                plcIp1.Enabled = true;
                plcPort1.Enabled = true;
                trigger1.Enabled = true;
                result1.Enabled = true;
            }
        }

        private void conn2En_CheckedChanged(object sender, EventArgs e)
        {
            if (!conn2En.Checked)
            {
                plcIp2.Enabled = false;
                plcPort2.Enabled = false;
                trigger2.Enabled = false;
                result2.Enabled = false;
            }
            else
            {
                plcIp2.Enabled = true;
                plcPort2.Enabled = true;
                trigger2.Enabled = true;
                result2.Enabled = true;
            }
        }

        private void conn3En_CheckedChanged(object sender, EventArgs e)
        {
            if (!conn3En.Checked)
            {
                plcIp3.Enabled = false;
                plcPort3.Enabled = false;
                trigger3.Enabled = false;
                result3.Enabled = false;
            }
            else
            {
                plcIp3.Enabled = true;
                plcPort3.Enabled = true;
                trigger3.Enabled = true;
                result3.Enabled = true;
            }
        }

        #endregion

        private void handStartInspect_Click(object sender, EventArgs e)
        {
            bool inspectRun = false;
            //拉取进程列表
            Process[] processes = Process.GetProcesses();
            //查找有没有inspect的进程
            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals("iworks"))
                {
                    inspectRun = true;
                }
            }

            //没有找到说明inspect没启动，启动inspect
            if (!inspectRun)
            {
                Process.Start(inspectPath);
                    
                if (isEmpty(allConnectData.delayStartInspect))
                {
                    Thread.Sleep(5000);
                    autoStartInspectTime.Text = "5";
                }
                else
                {
                    autoStartInspectTime.Text = allConnectData.delayStartInspect;
                    Thread.Sleep(int.Parse(allConnectData.delayStartInspect)*1000);
                }
            }
            else
            {
                MessageBox.Show("Inspect已启动");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void minForm_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Minimized;
                //任务栏区显示图标
                this.ShowInTaskbar = false;
                //托盘区图标隐藏
                notifyIcon1.Visible = true;
            }
        }
    }
}