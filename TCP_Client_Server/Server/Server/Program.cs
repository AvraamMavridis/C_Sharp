using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5004);
            listener.Start();
            TcpClient client;
            while (true)
            {
                client = listener.AcceptTcpClient();
                if (client.Connected)
                {
                    Console.WriteLine("client connected");
                    break;
                }

            }

            
            NetworkStream sr = client.GetStream();
            while (true)
            {
                byte[] message = new byte[1024];
                List<byte> msg = new List<byte>();
                sr.Read(message, 0, message.Length);
                msg.AddRange(message);
                msg.RemoveAll(RemoveNull);
                byte[] removemessage = msg.ToArray();
                sr.Flush();
                Console.WriteLine(Encoding.ASCII.GetString(removemessage));
               
            }
            sr.Close();
        }

        private static bool RemoveNull(byte s){
            if(s == (byte)0) return true;
            else return false;
        }


    }
}