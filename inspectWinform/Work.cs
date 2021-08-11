using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace InspectWinform
{
    class Work
    {
        public Socket plcSocket;
        public Socket localSocket;
        public string readCmd = "01WRD";
        public string writeCmd = "01WWR";
        public string camCmdAds;
        public string camResAds;
        public byte[] resBytes = new byte[1024];
        public string result;
        public bool san = true;
        private string lastCmd = "";

        public string plc1CmdAds;
        public string plc2CmdAds;
        public string plc3CmdAds;

        public Label triggerState;
        public Label triggerState1;

        private Thread currentThread;

        private bool inspectOK;

        private Timer timer;
        private int plcCmd;

        #region 线程主方法

        public void go()
        {
            currentThread = Thread.CurrentThread;

            timer = new Timer();
            timer.Interval = 1000;
            //timer.Enabled = true;
            timer.AutoReset = false;
            timer.Elapsed += timer_Tick;

            while (san)
            {
                for (int i = 0; i < resBytes.Length; i++)
                {
                    resBytes[i] = 0;
                }

                lock (this)
                {
                    result = "";
                    /*
                     *var plcCmdStr = InspectUtils.receiveDataFromTarget(plcSocket,resBytes);
                     *var plcCmd = int.Parse(plcCmdStr);
                     */
                    /*
                     * 读取PLC命令
                     */
                    plcCmd = getPlcCmd(plcSocket, camCmdAds);
                    if (plcCmd != 0)
                    {
                        triggerState1.BackColor = Color.Silver;
                        triggerState1.Text = "无";
                        /*inspectOK = true;
                        timer.Start();*/
                        result = readInspect(plcCmd);
                    }

                    if (result == "1" && inspectOK)
                    {
                        inspectOK = false;
                        timer.Stop();
                        timer.Enabled = false;
                        triggerState1.BackColor = Color.LimeGreen;
                        triggerState1.Text = "相机" + plcCmd + " OK";
                        setPlcCmd(plcSocket, camResAds, " 0001\r\n");
                        setPlcCmd(plcSocket, camCmdAds, " 0000\r\n");
                        result = "";
                        plcCmd = 0;
                    }
                    else if (result == "2" && inspectOK)
                    {
                        inspectOK = false;
                        timer.Stop();
                        timer.Enabled = false;
                        triggerState1.BackColor = Color.Red;
                        triggerState1.Text = "相机" + plcCmd + " NG";
                        setPlcCmd(plcSocket, camResAds, " 0002\r\n");
                        setPlcCmd(plcSocket, camCmdAds, " 0000\r\n");
                        result = "";
                        plcCmd = 0;
                    }
                    Thread.Sleep(10);
                }
            }
        }

        #endregion

        #region 设置PLC命令

        private string setPlcCmd(Socket socket, string plcAddress, string setResult)
        {
            string rtn = SocketUtils.sendCmdToTarget(socket, writeCmd + plcAddress + setResult + "\r\n");
            return rtn;
        }

        #endregion

        #region 获取PLC命令

        private int getPlcCmd(Socket socket, string plcAddress)
        {
            int enCamId = 0;
            SocketUtils.sendCmdToTarget(socket, readCmd + plcAddress + "\r\n");
            var cmd = SocketUtils.receiveDataFromTarget(socket, new byte[1024]);
            var indexOf = cmd.IndexOf('\r');
            if (indexOf != -1)
            {
                cmd = cmd.Substring(0, indexOf);
            }

            //更新界面触发状态指示
            if ("11OK0001".Equals(cmd))
            {
                triggerState.BackColor = Color.LimeGreen;
                inspectOK = true; //开启触发超时定时器
                timer.Start();
            }
            else if ("11OK0000".Equals(cmd))
            {
                triggerState.BackColor = Color.Yellow;
                inspectOK = false; //关闭触发超时定时器
                timer.Stop();
                timer.Enabled = false;
            }

            if (cmd == "11OK0001" && cmd != lastCmd)
            {
                if (plcAddress == plc1CmdAds)
                {
                    enCamId = 1;
                }

                if (plcAddress == plc2CmdAds)
                {
                    enCamId = 2;
                }

                if (plcAddress == plc3CmdAds)
                {
                    enCamId = 3;
                }
            }

            lastCmd = (string) cmd.Clone();
            return enCamId;
        }

        #endregion

        #region 获取Inspect结果

        private string readInspect(int camId)
        {
            /*InspectUtils.sendCmdToTarget(localSocket, "san;");
            string recStr = InspectUtils.receiveDataFromTarget(localSocket, resBytes);
            return recStr;*/
            string str = "";
            if (camId == 1)
            {
                str = "c1;";
            }
            else if (camId == 2)
            {
                str = "c2;";
            }
            else if (camId == 3)
            {
                str = "c3;";
            }

            SocketUtils.sendCmdToTarget(localSocket, str);
            var receiveData = SocketUtils.receiveDataFromTarget(localSocket, resBytes);
            return receiveData;
        }

        #endregion

        #region 触发超时定时器超时事件

        private void timer_Tick(object sender, EventArgs e)
        {
            if (inspectOK)
            {
                SocketUtils.sendCmdToTarget(plcSocket, readCmd + camCmdAds + "\r\n");
                var cmd = SocketUtils.receiveDataFromTarget(plcSocket, new byte[1024]);
                var indexOf = cmd.IndexOf('\r');
                if (indexOf != -1)
                {
                    cmd = cmd.Substring(0, indexOf);
                }
                if (cmd == "11OK0001")
                {
                    if (camCmdAds == plc1CmdAds)
                    {
                        plcCmd = 1;
                    }

                    if (camCmdAds == plc2CmdAds)
                    {
                        plcCmd = 2;
                    }

                    if (camCmdAds == plc3CmdAds)
                    {
                        plcCmd = 3;
                    }
                }
                SocketUtils.sendCmdToTarget(localSocket, "c" + plcCmd + ";");
                var receiveData = SocketUtils.receiveDataFromTarget(localSocket, resBytes);
                if (receiveData == "1")
                {
                    setPlcCmd(plcSocket, camResAds, " 0001\r\n");
                    triggerState1.BackColor = Color.LimeGreen;
                    triggerState1.Text = "相机" + plcCmd + " OK";
                }
                else if (receiveData == "2")
                {
                    triggerState1.BackColor = Color.Red;
                    triggerState1.Text = "相机" + plcCmd + " NG";
                    setPlcCmd(plcSocket, camResAds, " 0002\r\n");
                }
                else
                {
                    triggerState1.BackColor = Color.Silver;
                    triggerState1.Text = "无";
                }
            }
            setPlcCmd(plcSocket, camCmdAds, " 0000\r\n");
            inspectOK = false;
            result = "";
            plcCmd = 0;
        }

        #endregion
    }
}