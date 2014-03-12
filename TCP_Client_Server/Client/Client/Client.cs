using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Microsoft.Kinect;

namespace Client
{
    class Client
    {
        public TcpClient client;
        NetworkStream sw;
        KinectSensor sensor;
        int NumberOfKinectSensors;

        public Client()
        {
            client = new TcpClient();
            NumberOfKinectSensors = KinectSensor.KinectSensors.Count;

        }

        public void connectToServer()
        {
            Console.WriteLine("Insert server address");
            string server = Console.ReadLine();
            if (server == "")
            {
                server = "192.168.1.2";
            }
            client.Connect(IPAddress.Parse(server), 5004);
        }

        public void sendToServer(byte[] message)
        {
            sw = client.GetStream();
            sw.Write(message, 0, message.Length);
            sw.Flush();
        }

        public void closeStream()
        {
            sw.Close();
        }

    }
}
