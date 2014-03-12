using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client
{
    class Program
    {


        static void Main(string[] args)
        {
            Client cl = new Client();
            cl.connectToServer();
            while (true) { 
            byte[] message = Encoding.ASCII.GetBytes(Console.ReadLine());
            cl.sendToServer(message);
            }
            
        }


    }
}
