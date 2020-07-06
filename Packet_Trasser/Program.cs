using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Packet_Trasser
{
    class Program
    {
        static Socket s;
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 1433);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                s.Bind(ie);

                s.Listen(10);

                while(true)
                {
                    byte[] buffer = new byte[1024];
                    Socket handle = s.Accept();
                    int bytes = 0;

                    do
                    {
                        s.Receive(buffer);
                        Console.WriteLine(Encoding.Default.GetString(buffer, 0, bytes));
                    }
                    while (s.Available > 0);

                }
            }
            catch { }
        }

        void Recieve()
        {

        }

        void Send()
        {

        }
    }
}
