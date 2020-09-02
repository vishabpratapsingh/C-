using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net.Security;
using System.IO;

namespace ServerSide
{
  public  class ServerSideProgram
    {
        public static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8888);
            server.Start();
            Console.WriteLine("server started and waiting for clients.");
            Socket SocketForClients = server.AcceptSocket();
            if(SocketForClients.Connected){
                NetworkStream ns = new NetworkStream(SocketForClients);
                StreamWriter sw = new StreamWriter(ns);
                Console.WriteLine("server>> welcome client.");
                sw.WriteLine("welcome client");
                sw.Flush();
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine("client>>"+sr.ReadLine());
                sw.Close();
            }
            SocketForClients.Close();
        }
    }
}
