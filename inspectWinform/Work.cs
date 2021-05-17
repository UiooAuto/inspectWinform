using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace inspectWinform
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


        #region 线程主方法

        public void go()
        {
            Thread currentThread = Thread.CurrentThread;

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
                    int plcCmd = getPlcCmd(plcSocket, camCmdAds);
                    if (plcCmd != 0)
                    {
                        result = readInspect(plcCmd);
                    }

                    if (result == "1")
                    {
                        setPlcCmd(plcSocket, camResAds, " 0001\r\n");
                        setPlcCmd(plcSocket, camCmdAds, " 0000\r\n");
                    }
                    else if (result == "2")
                    {
                        setPlcCmd(plcSocket, camResAds, " 0002\r\n");
                        setPlcCmd(plcSocket, camCmdAds, " 0000\r\n");
                    }

                    result = "";
                    Thread.Sleep(100);
                }
            }
        }

        #endregion

        #region 设置PLC命令

        private string setPlcCmd(Socket socket, string plcAddress, string setResult)
        {
            string rtn = InspectUtils.sendCmdToTarget(socket, writeCmd + plcAddress + setResult + "\r\n");
            return rtn;
        }

        #endregion

        #region 获取PLC命令

        private int getPlcCmd(Socket socket, string plcAddress)
        {
            int enCamId = 0;
            InspectUtils.sendCmdToTarget(socket, readCmd + plcAddress + "\r\n");
            var cmd = InspectUtils.receiveDataFromTarget(socket, new byte[1024]);
            var indexOf = cmd.IndexOf('\r');
            if (indexOf != -1)
            {
                cmd = cmd.Substring(0, indexOf);
            }

            if (cmd == "11OK0001" && cmd != lastCmd)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "触发");
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

            InspectUtils.sendCmdToTarget(localSocket, str);
            var receiveData = InspectUtils.receiveDataFromTarget(localSocket, resBytes);
            return receiveData;
        }

        #endregion
    }
}