using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;

public class Timserver

{

    private static byte[]_buffer = new byte[1024];
    private static List<Socket> _clientSockets = new List<Socket>();
    private static Socket _serverSocket = new Socket
        (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

   public  static void Main(string[] args)
    {
        Console.Title = "SERVER";
        SetupServer();
        Console.ReadLine();
    }
    private  static void SetupServer()
    {
        Console.WriteLine("setting up server...");
        _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
        _serverSocket.Listen(5);
        _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);

    }
    private static void AcceptCallback(IAsyncResult AR)
    {
        Socket socket = _serverSocket.EndAccept(AR);
        _clientSockets.Add(socket);
        Console.WriteLine("client connected.");
        socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallback), socket);
    }
    private static void RecieveCallback(IAsyncResult AR)
    {
        Socket socket = (Socket)AR.AsyncState;
        int recieved = socket.EndReceive(AR);
        Byte[] dataBuf = new byte[recieved];
        Array.Copy(_buffer, dataBuf, recieved);

        string text = Encoding.ASCII.GetString(dataBuf);
        Console.WriteLine("Text recieved: " + text);


        string response = string.Empty;
        
        
        if(text.ToLower() != "get time")
        {
            response = "Invalid Request";
         }
        else
        {
           response = DateTime.Now.ToLongTimeString();
        }
        byte[] data = Encoding.ASCII.GetBytes(DateTime.Now.ToLongTimeString());
        socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);

    }
    private static void SendCallback(IAsyncResult AR)
    {
        Socket socket = (Socket)AR.AsyncState;
        socket.EndSend(AR);

    }
}