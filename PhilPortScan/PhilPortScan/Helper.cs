using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhilPortScan
{
    public class Helper
    {
        private IPAddress ipTarget { get; set; }
        private int startPort { get; set; }
        private int endPort { get; set; }
        public Helper(string ip, string portStart, string portEnd)
        {
            this.ipTarget = IPAddress.Parse(ip);
            this.startPort = Convert.ToInt32(portStart);
            this.endPort = Convert.ToInt32(portEnd);
        }

        public  void RunScan()
        {
            Console.Title = "PhilPortScan - Running!";
            Console.ForegroundColor = ConsoleColor.Cyan;
            for(int i = startPort; i <= endPort; i++)
            {
                Scan(i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "PhilPortScan";
        }

        private void Scan(int port)
        {
            IPEndPoint ipEndP = new IPEndPoint(this.ipTarget, port);
            try
            {
                TcpClient tcp = new TcpClient(ipEndP);
                Console.WriteLine(string.Format("{0} : {1} - OPEN", this.ipTarget.ToString(), port.ToString()));
                tcp.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
