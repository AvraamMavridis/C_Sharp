using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Program
    {


        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            Console.WriteLine("Insert server address");
            string server = Console.ReadLine();
            if (server == "")
            {
                server = "192.168.1.2";
            }
            client.Connect(IPAddress.Parse(server), 5004);

            NetworkStream sw = client.GetStream();
            while (true)
            {
                byte[] message = Encoding.ASCII.GetBytes(Console.ReadLine());
                sw.Write(message, 0, message.Length);
                sw.Flush();
                
                
            }
            sw.Close();

        }


    }
}
