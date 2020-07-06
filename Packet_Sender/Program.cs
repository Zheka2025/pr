using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Packet_Sender
{
    class Program
    {
        static Socket s;
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1433);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(ie);

            s.Send(Encoding.Default.GetBytes(Console.ReadLine()));
        }
    }
}
