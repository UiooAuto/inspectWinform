using System;
using System.Net.Sockets;
using System.Timers;

namespace inspectWinform
{
    public class ConnectThread
    {
        public Socket socket;
        private String serverIp;
        private int serverPort;
        public int timerNum;
        private Timer timer;
        
        public void go()
        {
            connect();
        }

        private void connect()
        {
            Socket socket = InspectUtils.connectToTarget(serverIp, serverPort);
        }
    }
}