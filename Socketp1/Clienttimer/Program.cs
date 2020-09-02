using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Net.Sockets;
using System.Linq;
using System.Net;

public class ClientTimer
{
    private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

     public static void Main(string[] args)
    {
        Console.Title = "CLIENT";
        LoopConnect();
        SendLoop();
        Console.ReadLine();
    }
    private static void SendLoop()
    {
        while(true)
        {
            Console.Write("Enter a Request:");
            string req=Console.ReadLine();
            byte[] buffer = Encoding.ASCII.GetBytes(req);
            _clientSocket.Send(buffer);
            byte[] receivedBuf = new byte[1024];
            int rec = _clientSocket.Receive(receivedBuf);
            byte[] data = new byte[rec];
            Array.Copy(receivedBuf, data, rec);
            Console.WriteLine("Recieved: " + Encoding.ASCII.GetString(data));


        }
    }
    private static void LoopConnect()
    {
        int attempts = 0;
        while (!_clientSocket.Connected)
        {

            try
            {
                attempts++;

                _clientSocket.Connect(IPAddress.Loopback, 100);
            }
            catch (SocketException)
            {
                Console.Clear();
                Console.WriteLine("Connection Attempts: " + attempts.ToString());

            }
        }
        Console.Clear();
        Console.WriteLine("connected");
    }
}

 