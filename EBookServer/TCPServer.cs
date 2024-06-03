using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EBookServer
{
    public class TCPServer
    {
        private TcpListener listener;
        private bool isRunning;

        public TCPServer(string ip, int port)
        {
            listener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public void Start()
        {
            listener.Start();
            isRunning = true;
            //Console.WriteLine("Server started...");

            while (isRunning)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    //Console.WriteLine("Client connected...");

                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(client);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buff = new byte[256];
            int bytesRead;

            try
            {
                while ((bytesRead = stream.Read(buff, 0, buff.Length)) != 0)
                {
                    string message = Encoding.ASCII.GetString(buff, 0, bytesRead);
                    //Console.WriteLine("Received: " + message);

                    string response = "Server received: " + message;
                    byte[] responseData = Encoding.ASCII.GetBytes(response);
                    stream.Write(responseData, 0, responseData.Length);
                    //Console.WriteLine("Sent: " + response);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Client connection error: " + ex.Message);
            }
            finally
            {
                stream.Close();
                client.Close();
            }
        }

        public void Stop()
        {
            isRunning = false;
            listener.Stop();
            //Console.WriteLine("Server stopped...");
        }
    }
}
