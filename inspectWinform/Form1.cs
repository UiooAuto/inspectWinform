using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InspectWinform
{
    public partial class Form1 : Form
    {
        public string readCmd = "01WRDD";
        public string writeCmd = "01WWRD";
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

        //准备plc所用的各种地址
        string cam1CmdAds;
        string cam1ResAds;
        string cam2CmdAds;
        string cam2ResAds;
        string cam3CmdAds;
        string cam3ResAds;

        //用于判断连接状态
        bool connectStatus = false;
        public int overTimeSet;

        private Thread thread1;
        private Thread thread2;
        private Thread thread3;

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

            //读取前一次的连接数据
            readSaveData();

            //界面中已保存值恢复
            inspectIp.Text = allConnectData.inspectIp;
            inspectPort.Text = allConnectData.inspectPort;
            plcIp1.Text = allConnectData.plcIp1;
            plcPort1.Text = allConnectData.plcPort1;

            trigger1.Text = allConnectData.cam1CmdAds;
            trigger2.Text = allConnectData.cam2CmdAds;
            trigger3.Text = allConnectData.cam3CmdAds;
            result1.Text = allConnectData.cam1ResAds;
            result2.Text = allConnectData.cam2ResAds;
            result3.Text = allConnectData.cam3ResAds;

            autoConTimeSet.Text = allConnectData.autoConnTime;

            cb_EnCam1.Checked = allConnectData.con1En;
            cb_EnCam2.Checked = allConnectData.con2En;
            cb_EnCam3.Checked = allConnectData.con3En;

            if (isEmpty(allConnectData.overTimeSet))
            {
                overTime.Text = "2";
            }
            else
            {
                overTime.Text = allConnectData.overTimeSet;
            }

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

            if (isEmpty(allConnectData.delayStartInspect))
            {
                autoStartInspectTime.Text = "5";
            }
            else
            {
                autoStartInspectTime.Text = allConnectData.delayStartInspect;
            }
            
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
                        Thread.Sleep(int.Parse(allConnectData.delayStartInspect) * 1000);
                    }
                }

                //开始连接
                bool v = startConnect();
                if (v)
                {
                    minWindow();//连接成功才会最小化
                }
                else
                {
                    MessageBox.Show("连接失败");
                }
            }
        }

        #endregion

        #region 点击连接按钮

        private void connectAll_Click(object sender, EventArgs e)
        {
            startConnect();
        }

        #endregion

        #region 重做部分

        #region 连接参数

        public Socket inspect;
        public Socket plc;

        #endregion

        #region 程序主要工作流程

        public static bool san = false;
        public static bool readByPass = false;
        public void Work()
        {
            string lastCmd1 = "";
            string lastCmd2 = "";
            string lastCmd3 = "";

            string readResult1 = "";
            string readResult2 = "";
            string readResult3 = "";

            string inspectResult1 = "";
            string inspectResult2 = "";
            string inspectResult3 = "";

            while (san && !readByPass)
            {
                /*string cam1Result = "";
                string cam2Result = "";
                string cam3Result = "";*/

                bool triggerCam1 = false;
                bool triggerCam2 = false;
                bool triggerCam3 = false;

                byte[] recBytes = new byte[1024 * 1024];

                if (cb_EnCam1.Checked)
                {
                    //读取plc
                    Array.Clear(recBytes, 0, recBytes.Length);
                    string cmd = readCmd + cam1CmdAds+"\r\n";
                    plc.Send(Encoding.UTF8.GetBytes(cmd));
                    int v = plc.Receive(recBytes);

                    Thread.Sleep(30);

                    readResult1 = Encoding.UTF8.GetString(recBytes, 0, v);

                    int indexOf = readResult1.IndexOf('\r');
                    if (indexOf != -1)
                    {
                        readResult1 = readResult1.Substring(0, indexOf);
                    }
                }
                else
                {
                    readResult1 = "";
                }

                if (cb_EnCam2.Checked)
                {
                    //读取plc
                    Array.Clear(recBytes, 0, recBytes.Length);
                    string cmd = readCmd + cam1CmdAds+"\r\n";
                    plc.Send(Encoding.UTF8.GetBytes(cmd));
                    int v = plc.Receive(recBytes);

                    Thread.Sleep(30);

                    readResult2 = Encoding.UTF8.GetString(recBytes, 0, v);

                    int indexOf = readResult2.IndexOf('\r');
                    if (indexOf != -1)
                    {
                        readResult2 = readResult2.Substring(0, indexOf);
                    }
                }
                else
                {
                    readResult2 = "";
                }

                if (cb_EnCam3.Checked)
                {
                    //读取plc
                    Array.Clear(recBytes, 0, recBytes.Length);
                    string cmd = readCmd + cam1CmdAds+"\r\n";
                    plc.Send(Encoding.UTF8.GetBytes(cmd));
                    int v = plc.Receive(recBytes);

                    Thread.Sleep(30);

                    readResult3 = Encoding.UTF8.GetString(recBytes, 0, v);

                    int indexOf = readResult3.IndexOf('\r');
                    if (indexOf != -1)
                    {
                        readResult3 = readResult3.Substring(0, indexOf);
                    }
                }
                else
                {
                    readResult3 = "";
                }

                if (String.IsNullOrWhiteSpace(readResult1))
                {
                    if (readResult1 != lastCmd1)//代表指令有更新
                    {
                        if ("11OK0000".Equals(readResult1))//0代表一个也不触发
                        {
                            triggerCam1 = false;
                            trigger1State.BackColor = Color.Yellow;
                        }
                        else if ("11OK0001".Equals(readResult1))//发1代表全部触发
                        {
                            triggerCam1 = true;
                            trigger1State.BackColor = Color.Green;
                        }
                        lastCmd1 = readResult1;
                    }
                    else
                    {
                        lastCmd1 = readResult1;
                    }
                }

                if (String.IsNullOrWhiteSpace(readResult2))
                {
                    if (readResult2 != lastCmd2)//代表指令有更新
                    {
                        if ("11OK0000".Equals(readResult2))//0代表一个也不触发
                        {
                            triggerCam2 = false;
                            trigger2State.BackColor = Color.Yellow;
                        }
                        else if ("11OK0001".Equals(readResult2))//发1代表全部触发
                        {
                            triggerCam2 = true;
                            trigger2State.BackColor = Color.Green;
                        }
                        lastCmd2 = readResult2;
                    }
                    else
                    {
                        lastCmd2 = readResult2;
                    }
                }

                if (String.IsNullOrWhiteSpace(readResult3))
                {
                    if (readResult3 != lastCmd3)//代表指令有更新
                    {
                        if ("11OK0000".Equals(readResult3))//0代表一个也不触发
                        {
                            triggerCam3 = false;
                            trigger3State.BackColor = Color.Yellow;
                        }
                        else if ("11OK0001".Equals(readResult3))//发1代表全部触发
                        {
                            triggerCam3 = true;
                            trigger3State.BackColor = Color.Green;
                        }
                        lastCmd3 = readResult3;
                    }
                    else
                    {
                        lastCmd3 = readResult3;
                    }
                }

                if (!(triggerCam1 || triggerCam2 || triggerCam3))
                {
                    //如果一个都没触发，开始下一次读取
                    continue;
                }

                //触发inspect，并发送对应指令。获取结果
                if (triggerCam1)
                {
                    Array.Clear(recBytes, 0, recBytes.Length);
                    inspect.Send(Encoding.UTF8.GetBytes("c1;"));
                    int v1 = inspect.Receive(recBytes);
                    Thread.Sleep(30);
                    inspectResult1 = Encoding.UTF8.GetString(recBytes, 0, v1);
                }

                if (triggerCam2)
                {
                    Array.Clear(recBytes, 0, recBytes.Length);
                    inspect.Send(Encoding.UTF8.GetBytes("c2;"));
                    int v1 = inspect.Receive(recBytes);
                    Thread.Sleep(30);
                    inspectResult2 = Encoding.UTF8.GetString(recBytes, 0, v1);
                }

                if (triggerCam3)
                {
                    Array.Clear(recBytes, 0, recBytes.Length);
                    inspect.Send(Encoding.UTF8.GetBytes("c3;"));
                    int v1 = inspect.Receive(recBytes);
                    Thread.Sleep(30);
                    inspectResult3 = Encoding.UTF8.GetString(recBytes, 0, v1);
                }

                

                if (triggerCam1)
                {
                    if ("1" == inspectResult1)//只检测上面并且检测ok则返回plc1，检测NG则返回3
                    {
                        Array.Clear(recBytes, 0, recBytes.Length);
                        string cmdStr = writeCmd + cam1ResAds + " 0001\r\n";
                        plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                        int v1 = plc.Receive(recBytes);
                        Thread.Sleep(30);
                    }
                    else
                    {
                        Array.Clear(recBytes, 0, recBytes.Length);
                        string cmdStr = writeCmd + cam1ResAds + " 0002\r\n";
                        plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                        int v1 = plc.Receive(recBytes);
                        Thread.Sleep(30);
                    }

                    //清楚PLC的触发位
                    Array.Clear(recBytes, 0, recBytes.Length);
                    string cmdStr1 = writeCmd + cam1CmdAds + " 0000\r\n";
                    plc.Send(Encoding.UTF8.GetBytes(cmdStr1));
                    plc.Receive(recBytes);
                    Thread.Sleep(30);
                }

                if (triggerCam2)
                {
                    if ("1" == inspectResult2)//只检测上面并且检测ok则返回plc1，检测NG则返回3
                    {
                        Array.Clear(recBytes, 0, recBytes.Length);
                        string cmdStr = writeCmd + cam2ResAds + " 0001\r\n";
                        plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                        int v1 = plc.Receive(recBytes);
                        Thread.Sleep(30);
                    }
                    else
                    {
                        Array.Clear(recBytes, 0, recBytes.Length);
                        string cmdStr = writeCmd + cam2ResAds + " 0002\r\n";
                        plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                        int v1 = plc.Receive(recBytes);
                        Thread.Sleep(30);
                    }

                    //清楚PLC的触发位
                    Array.Clear(recBytes, 0, recBytes.Length);
                    string cmdStr1 = writeCmd + cam2CmdAds + " 0000\r\n";
                    plc.Send(Encoding.UTF8.GetBytes(cmdStr1));
                    plc.Receive(recBytes);
                    Thread.Sleep(30);
                }

                if (triggerCam3)
                {
                    if ("1" == inspectResult3)//只检测上面并且检测ok则返回plc1，检测NG则返回3
                    {
                        Array.Clear(recBytes, 0, recBytes.Length);
                        string cmdStr = writeCmd + cam3ResAds + " 0001\r\n";
                        plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                        int v1 = plc.Receive(recBytes);
                        Thread.Sleep(30);
                    }
                    else
                    {
                        Array.Clear(recBytes, 0, recBytes.Length);
                        string cmdStr = writeCmd + cam3ResAds + " 0002\r\n";
                        plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                        int v1 = plc.Receive(recBytes);
                        Thread.Sleep(30);
                    }

                    //清楚PLC的触发位
                    Array.Clear(recBytes, 0, recBytes.Length);
                    string cmdStr1 = writeCmd + cam3CmdAds + " 0000\r\n";
                    plc.Send(Encoding.UTF8.GetBytes(cmdStr1));
                    plc.Receive(recBytes);
                    Thread.Sleep(30);
                }
            }
        }

        #endregion

        #endregion

        #region 连接功能

        public bool startConnect()
        {
            //给PLC连接地址赋值,如果有一个没填写都认为是空
            if (cb_EnCam1.Checked && !String.IsNullOrWhiteSpace(trigger1.Text) && !String.IsNullOrWhiteSpace(result1.Text))
            {
                cam1CmdAds = "D" + trigger1.Text + " 01";
                cam1ResAds = "D" + result1.Text + " 01";
            }
            else
            {
                cam1CmdAds = null;
                cam1ResAds = null;
            }   
            if (cb_EnCam2.Checked && !String.IsNullOrWhiteSpace(trigger2.Text) && !String.IsNullOrWhiteSpace(result2.Text))
            {
                cam2CmdAds = "D" + trigger2.Text + " 01";
                cam2ResAds = "D" + result2.Text + " 01";
            }
            else
            {
                cam2CmdAds = null;
                cam2ResAds = null;
            }   
            if (cb_EnCam3.Checked && !String.IsNullOrWhiteSpace(trigger3.Text) && !String.IsNullOrWhiteSpace(result3.Text))
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
            if ("关闭连接".Equals(connectAll.Text))
            {
                closeAllSocket(); //关闭所有连接
                connectAll.Text = "连接";
                connectAll.BackColor = Color.Silver;
                trigger1State.BackColor = Color.Silver;
                trigger2State.BackColor = Color.Silver;
                trigger3State.BackColor = Color.Silver;
                cb_EnCam1.Enabled = true;
                cb_EnCam2.Enabled = true;
                cb_EnCam3.Enabled = true;
            }
            else
            {
                //否则建立全部连接
                bool v = connectAllcon(); 
                if (v)
                {
                    //开始工作
                    startWork();
                }
                else
                {
                    return false;
                }
            }
            return true;
            //根据连接状态使画面上的输入框只读
            //enTextBoxs();
        }

        #endregion

        #region 启动程序主要功能

        /// <summary>
        /// 启动程序主要功能
        /// </summary>
        public void startWork()
        {
            overTimeSet = (int)(double.Parse(overTime.Text) * 1000 / 1);
            //仅当对应plc有连接的时候，才开启线程
            san = true;
            Thread cheakthread = new Thread(new ThreadStart(Work));
            cheakthread.IsBackground = true;
            cheakthread.Start();
        }

        #endregion

        #region 连接所有连接

        /// <summary>
        /// 建立所有连接
        /// </summary>
        public bool connectAllcon()
        {
            if (!cb_EnCam1.Checked && !cb_EnCam1.Checked && !cb_EnCam1.Checked)
            {
                MessageBox.Show("至少开启一个相机");
                return false;
            }

            //用于标识是否有连接建立成功
            bool flag = false;
            bool inspectRun = false;//inspect是否开启了
            Process[] processes = Process.GetProcesses();
            //查找有没有inspect的进程
            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals("iworks"))
                {
                    inspectRun = true;
                }
            }

            if (!inspectRun)
            {
                MessageBox.Show("视觉检测程序未开启");
                return false;
            }            

            if (plc == null & !isEmpty(plcIp1.Text) & !isEmpty(plcPort1.Text))//连接PLC
            {
                plc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                plc.SendTimeout = 500;
                plc.ReceiveTimeout = 500;

                Ping ping = new Ping();
                PingReply pingReply = ping.Send(plcIp1.Text, 1000);
                if (pingReply.Status == IPStatus.Success)
                {
                    plc.Connect(new IPEndPoint(IPAddress.Parse(plcIp1.Text), int.Parse(plcPort1.Text)));
                    flag = true;
                }
                else
                {
                    MessageBox.Show("PLC连接超时");
                    return false;
                }
            }

            if (flag)
            {

                //只有在有连接参数、有PLC连接成功、Inspect开启时才连接Inspect
                if (inspect == null & !isEmpty(inspectIp.Text) & !isEmpty(inspectPort.Text))
                {
                    inspect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    inspect.SendTimeout = 5000;
                    inspect.ReceiveTimeout = 5000;
                    inspect.Connect(new IPEndPoint(IPAddress.Parse(inspectIp.Text), int.Parse(inspectPort.Text)));
                }

                testMsg.Text = "无";
                testMsg.BackColor = Color.Silver;
                connectAll.Text = "关闭连接";
                connectAll.BackColor = Color.LimeGreen;
                connectStatus = true;

                return true;
            }
            else
            {
                MessageBox.Show("连接失败");
                return false;
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
            testMsg.Text = "无";
            testMsg.BackColor = Color.Silver;

            byte[] recBytes = new byte[1024 * 1024];

            readByPass = true;//暂停主线程读取
            Thread.Sleep(700);//Work线程全部sleep为500,这个700是经验值

            Array.Clear(recBytes, 0, recBytes.Length);
            inspect.Send(Encoding.UTF8.GetBytes("c1;"));
            int v1 = inspect.Receive(recBytes);
            Thread.Sleep(30);
            string inspectResult = Encoding.UTF8.GetString(recBytes, 0, v1);

            if ("1" == inspectResult)//只检测上面并且检测ok则返回plc1，检测NG则返回3
            {
                Array.Clear(recBytes, 0, recBytes.Length);
                string cmdStr = writeCmd + cam1ResAds + " 0001\r\n";
                plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                plc.Receive(recBytes);
                Thread.Sleep(30);
            }
            else
            {
                Array.Clear(recBytes, 0, recBytes.Length);
                string cmdStr = writeCmd + cam1ResAds + " 0002\r\n";
                plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                plc.Receive(recBytes);
                Thread.Sleep(30);
            }

            //清楚PLC的触发位
            Array.Clear(recBytes, 0, recBytes.Length);
            string cmdStr1 = writeCmd + cam1CmdAds + " 0000\r\n";
            plc.Send(Encoding.UTF8.GetBytes(cmdStr1));
            plc.Receive(recBytes);
            Thread.Sleep(30);
        }

        private void cmdCam2_Click(object sender, EventArgs e)
        {
            testMsg.Text = "无";
            testMsg.BackColor = Color.Silver;

            byte[] recBytes = new byte[1024 * 1024];

            readByPass = true;//暂停主线程读取
            Thread.Sleep(700);//Work线程全部sleep为500,这个700是经验值

            Array.Clear(recBytes, 0, recBytes.Length);
            inspect.Send(Encoding.UTF8.GetBytes("c2;"));
            int v1 = inspect.Receive(recBytes);
            Thread.Sleep(30);
            string inspectResult = Encoding.UTF8.GetString(recBytes, 0, v1);

            if ("1" == inspectResult)//只检测上面并且检测ok则返回plc1，检测NG则返回3
            {
                Array.Clear(recBytes, 0, recBytes.Length);
                string cmdStr = writeCmd + cam2ResAds + " 0001\r\n";
                plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                plc.Receive(recBytes);
                Thread.Sleep(30);
            }
            else
            {
                Array.Clear(recBytes, 0, recBytes.Length);
                string cmdStr = writeCmd + cam2ResAds + " 0002\r\n";
                plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                plc.Receive(recBytes);
                Thread.Sleep(30);
            }

            //清楚PLC的触发位
            Array.Clear(recBytes, 0, recBytes.Length);
            string cmdStr1 = writeCmd + cam2CmdAds + " 0000\r\n";
            plc.Send(Encoding.UTF8.GetBytes(cmdStr1));
            plc.Receive(recBytes);
            Thread.Sleep(30);
        }

        private void cmdCam3_Click(object sender, EventArgs e)
        {
            testMsg.Text = "无";
            testMsg.BackColor = Color.Silver;

            byte[] recBytes = new byte[1024 * 1024];

            readByPass = true;//暂停主线程读取
            Thread.Sleep(700);//Work线程全部sleep为500,这个700是经验值

            Array.Clear(recBytes, 0, recBytes.Length);
            inspect.Send(Encoding.UTF8.GetBytes("c3;"));
            int v1 = inspect.Receive(recBytes);
            Thread.Sleep(30);
            string inspectResult = Encoding.UTF8.GetString(recBytes, 0, v1);

            if ("1" == inspectResult)//只检测上面并且检测ok则返回plc1，检测NG则返回3
            {
                Array.Clear(recBytes, 0, recBytes.Length);
                string cmdStr = writeCmd + cam3ResAds + " 0001\r\n";
                plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                plc.Receive(recBytes);
                Thread.Sleep(30);
            }
            else
            {
                Array.Clear(recBytes, 0, recBytes.Length);
                string cmdStr = writeCmd + cam3ResAds + " 0002\r\n";
                plc.Send(Encoding.UTF8.GetBytes(cmdStr));
                plc.Receive(recBytes);
                Thread.Sleep(30);
            }

            //清楚PLC的触发位
            Array.Clear(recBytes, 0, recBytes.Length);
            string cmdStr1 = writeCmd + cam3CmdAds + " 0000\r\n";
            plc.Send(Encoding.UTF8.GetBytes(cmdStr1));
            plc.Receive(recBytes);
            Thread.Sleep(30);
        }

        #endregion

        #region 自动检测连接状态并更新界面

        public void AutoCheckConnect()
        {
            while (true)
            {
                if (plc != null)
                {
                    if (!plc.Connected)
                    {
                        startConnect();
                        testMsg.Text = "连接中断";
                        testMsg.BackColor = Color.Red;
                        return;
                    }
                }
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
            san = false;

            if (inspect != null)
            {
                try
                {
                    inspect.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    inspect.Close();
                }
                catch
                {
                }
            }

            if (plc != null)
            {
                try
                {
                    plc.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    plc.Close();
                }
                catch
                {
                }
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
                plcPort1.ReadOnly = false;

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
                Thread.Sleep(10);
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
            allConnectData.plcPort1 = plcPort1.Text;

            allConnectData.cam1CmdAds = trigger1.Text;
            allConnectData.cam2CmdAds = trigger2.Text;
            allConnectData.cam3CmdAds = trigger3.Text;
            allConnectData.cam1ResAds = result1.Text;
            allConnectData.cam2ResAds = result2.Text;
            allConnectData.cam3ResAds = result3.Text;

            allConnectData.autoConnTime = autoConTimeSet.Text;

            allConnectData.con1En = cb_EnCam1.Checked;
            allConnectData.con2En = cb_EnCam2.Checked;
            allConnectData.con3En = cb_EnCam3.Checked;

            allConnectData.delayStartInspect = autoStartInspectTime.Text;
            allConnectData.overTimeSet = overTime.Text;

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
        private void cb_EnCam1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnCam1.Checked)
            {
                gb_Cam1.Enabled = true;
            }
            else
            {
                gb_Cam1.Enabled = false;
            }
        }

        private void cb_EnCam2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnCam2.Checked)
            {
                gb_Cam2.Enabled = true;
            }
            else
            {
                gb_Cam2.Enabled = false;
            }
        }

        private void cb_EnCam3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnCam3.Checked)
            {
                gb_Cam3.Enabled = true;
            }
            else
            {
                gb_Cam3.Enabled = false;
            }
        }

        #endregion

        #region 手动打开Inspect

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
                    Thread.Sleep(int.Parse(allConnectData.delayStartInspect) * 1000);
                }
            }
            else
            {
                MessageBox.Show("Inspect已启动");
            }
        }

        #endregion

        #region 点击系统托盘图标，还原程序窗口

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

        #endregion

        #region 将程序最小化到托盘

        private void minWindow()
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

        #endregion

        #region 点击最小化按钮事件

        private void minForm_Click(object sender, EventArgs e)
        {
            minWindow();
        }

        #endregion
        
    }
    #region 圆形标签类
    public class CircleLabel : Label//继承标签类    重新生成解决方案就能看见我啦
    {
        protected override void OnPaint(PaintEventArgs e)//重新设置控件的形状   protected 保护  override重新
        {
            base.OnPaint(e);//递归  每次重新都发生此方法,保证其形状为自定义形状
            System.Drawing.Drawing2D.GraphicsPath path =new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(2, 2,this.Width - 6,this.Height - 6);
            //Graphics g = e.Graphics;
            //g.DrawEllipse(new Pen(Color.Red, 2), 2, 2, Width - 6, Height - 6);
            Region =new Region(path);
        }
    }
 
    #endregion
}