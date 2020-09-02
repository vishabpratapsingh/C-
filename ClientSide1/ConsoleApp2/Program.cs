using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8888);
            server.Start();
            Console.WriteLine("server started and waiting for clients.");
            Socket SocketForClients = server.AcceptSocket();
            if (SocketForClients.Connected)
            {
                NetworkStream ns = new NetworkStream(SocketForClients);
                StreamWriter sw = new StreamWriter(ns);
                Console.WriteLine("server>> welcome client.");
                sw.WriteLine("welcome client");
                sw.Flush();
                sw.Close();
            }
            SocketForClients.Close();
        }
    }
}
