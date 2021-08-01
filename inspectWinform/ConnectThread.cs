using System;
using System.Net.Sockets;
using System.Timers;

namespace InspectWinform
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
            Socket socket = SocketUtils.connectToTarget(serverIp, serverPort);
        }
    }
}