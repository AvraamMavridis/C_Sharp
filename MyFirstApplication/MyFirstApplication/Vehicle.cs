using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class Vehicle
    {
        public Vehicle(int speed, Colors c=Colors.Blue) { 
         speed_ = speed; color_ = c;
         Console.WriteLine("Base class constructor"); 
        }
        public virtual int getSpeed() { return speed_;}
        private int speed_;
        public Colors color_ { get;  set; }
        public void printVehicle() { Console.WriteLine("Color: {0}",this.color_);}
    }
}
