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
        ConnectInfo inspectConnectInfo;
        ConnectInfo[] plcConnectArr = new ConnectInfo[3];

        public byte[] resByteArr = new byte[1024];

        Socket inspectSocket;
        Socket plcSocket1;
        Socket plcSocket2;
        Socket plcSocket3;

        static Work work1 = new Work();
        static Work work2 = new Work();
        static Work work3 = new Work();

        string cam1CmdAds = "D6030 01";
        string cam1ResAds = "D6032 01 ";
        string cam2CmdAds = "D8030 01";
        string cam2ResAds = "D8032 01 ";
        string cam3CmdAds = "D10030 01";
        string cam3ResAds = "D10032 01 ";

        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            inspectConnectInfo = new ConnectInfo();
            plcConnectArr[0] = new ConnectInfo();
            plcConnectArr[1] = new ConnectInfo();
            plcConnectArr[2] = new ConnectInfo();
        }

        #region 启动程序主要功能

        /// <summary>
        /// 启动程序主要功能
        /// </summary>
        public void startWork()
        {
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
            bool flag = true;
            if (inspectSocket == null & !isEmpty(inspectIp.Text) & !isEmpty(inspectPort.Text))
            {
                inspectConnectInfo.ip = inspectIp.Text;
                inspectConnectInfo.port = int.Parse(inspectPort.Text);
                inspectSocket = InspectUtils.connectToTarget(inspectConnectInfo.ip, inspectConnectInfo.port);
                if (inspectSocket == null)
                {
                    flag = false;
                }
            }

            if (plcSocket1 == null & !isEmpty(plcIp1.Text) & !isEmpty(plcPort1.Text))
            {
                plcConnectArr[0].ip = plcIp1.Text;
                plcConnectArr[0].port = int.Parse(plcPort1.Text);
                plcSocket1 = InspectUtils.connectToTarget(plcConnectArr[0].ip, plcConnectArr[0].port);
                if (inspectSocket == null)
                {
                    flag = false;
                }
            }

            if (plcSocket2 == null & !isEmpty(plcIp2.Text) & !isEmpty(plcPort2.Text))
            {
                plcConnectArr[1].ip = plcIp2.Text;
                plcConnectArr[1].port = int.Parse(plcPort2.Text);
                plcSocket2 = InspectUtils.connectToTarget(plcConnectArr[1].ip, plcConnectArr[1].port);
                if (inspectSocket == null)
                {
                    flag = false;
                }
            }

            if (plcSocket3 == null & !isEmpty(plcIp3.Text) & !isEmpty(plcPort3.Text))
            {
                plcConnectArr[2].ip = plcIp3.Text;
                plcConnectArr[2].port = int.Parse(plcPort3.Text);
                plcSocket3 = InspectUtils.connectToTarget(plcConnectArr[2].ip, plcConnectArr[2].port);
                if (inspectSocket == null)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                connectAll.Text = "已连接";
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
            if ((inspectSocket != null && inspectSocket.Connected)
                || plcSocket1 != null && plcSocket1.Connected
                || plcSocket2 != null && plcSocket2.Connected
                || plcSocket3 != null && plcSocket3.Connected)
            {
                MessageBox.Show("正在关闭连接");
                closeAllSocket();
                connectAll.Text = "连接";
            }
            else
            {
                MessageBox.Show("正在连接");
                connectAllcon();
                startWork(); 
            }
            
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
        }

        #endregion
    }
}