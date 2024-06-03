using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EBookClient
{
    public class TCPClient
    {
        private string serverIp;
        private int serverPort;
        private TcpClient client;
        private NetworkStream stream;

        public TCPClient(string ip, int port)
        {
            serverIp = ip;
            serverPort = port;
            client = new TcpClient();
        }

        public bool Connect()
        {
            try
            {
                client.Connect(serverIp, serverPort);
                stream = client.GetStream();
                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error connecting to server: " + ex.Message);
                return false;
            }
        }

        public void SendMessage(string message)
        {
            if (stream == null || !client.Connected)
            {
                //Console.WriteLine("Not connected to server.");
                return;
            }

            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            byte[] responseData = new byte[256];
            int bytes = stream.Read(responseData, 0, responseData.Length);
            string response = Encoding.ASCII.GetString(responseData, 0, bytes);
            Console.WriteLine("Received: " + response);
        }

        public void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
