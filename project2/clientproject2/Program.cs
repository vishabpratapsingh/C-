using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousClientSocketPrograming
{
    public class StateObject
    {

        public Socket workSocket = null;

        public const int BufferSize = 256;

        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }
    class AsynchronousClient
    {
        private const int port = 1100;

        private static ManualResetEvent connectDone = new ManualResetEvent(false);

        private static ManualResetEvent sendDone = new ManualResetEvent(false);

        private static ManualResetEvent receiveDone = new ManualResetEvent(false);

        private static String response = String.Empty;
        public static void Main(string[] args)
        {
            StartClient();

            Console.ReadKey();
        }


        public static void StartClient()
        {
            try
            {
                IPHostEntry iphostInfo = Dns.GetHostEntry(Dns.GetHostName());

                IPAddress iPAddress = iphostInfo.AddressList[0];

                IPEndPoint remoteEP = new IPEndPoint(iPAddress, port);

                Socket client = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);


                client.BeginConnect(remoteEP, new AsyncCallback(connectCallback), client);


                //Blocks the current thread until the current WaitHandle receives a signal.
                connectDone.WaitOne();


                Send(client, "this is test <eof>");


                sendDone.WaitOne();

                Receive(client);

                receiveDone.WaitOne();

                Console.WriteLine("response recives :{0}", response);
                client.Shutdown(SocketShutdown.Both);
                client.Close();




            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }
        private static void connectCallback(IAsyncResult ar)
        {

            try
            {
                Socket client = (Socket)ar.AsyncState;

                client.EndConnect(ar);

                Console.WriteLine("socket connected to {0}", client.RemoteEndPoint.ToString());


                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void Send(Socket client, string data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);


            client.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                int bytesSend = client.EndSend(ar);

                Console.WriteLine("send {0} bytes server", bytesSend);
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        private static void Receive(Socket client)
        {

            try
            {
                StateObject state = new StateObject();
                state.workSocket = client;

                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(recivedCallBack), state);



            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void recivedCallBack(IAsyncResult ar)
        {
            try
            {
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)

                {
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));


                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(recivedCallBack), state);

                }
                else
                {

                    if (state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }

                    receiveDone.Set();
                }
            }
            catch (Exception e)

            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}