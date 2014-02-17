using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myFirst = new Vehicle(100,Colors.Red);
            Console.WriteLine("Color of Vehicle {0}, speed of Vehicle {1}", myFirst.color_,myFirst.getSpeed());
          
            Vehicle[,] vehicles = new Vehicle[,]{
                {myFirst}
            };
            vehicles[0, 0].color_ = Colors.Blue;
            Console.WriteLine("Color of Vehicle {0}, speed of Vehicle {1}", myFirst.color_,myFirst.getSpeed());

            ArrayList listOfVehicles = new ArrayList();
            listOfVehicles.Add(new Vehicle(200, Colors.Red));
            listOfVehicles.Add(new Vehicle(300, Colors.Greem));
            listOfVehicles.Add(new Motorcycle(299, Colors.Blue));
            listOfVehicles.Add(100);
            listOfVehicles.Add("dadsadsa");
            foreach(Object obj in listOfVehicles){
                if (obj is Vehicle)
                {
                    Vehicle ob = (Vehicle)obj;
                    Console.WriteLine(ob.getSpeed());
                    ob.printVehicle();
                }
            }

            Vehicle[,] arrayOfVehicles = new Vehicle[,]{
                {myFirst,(Vehicle)listOfVehicles[0]},
                {(Vehicle)listOfVehicles[1],(Vehicle)listOfVehicles[2]}

            };

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(arrayOfVehicles[i, j].getSpeed());
                    Console.ReadLine();
       
        }
    }
}
