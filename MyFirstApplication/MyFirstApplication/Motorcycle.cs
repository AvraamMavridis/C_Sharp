using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class Motorcycle : Vehicle
    {
        private int p;
        private Colors colors;

        public Motorcycle(int s, Colors c) : base(s, c) { Console.WriteLine("Subclass constructor"); }

        public override int getSpeed() { return base.getSpeed() + 10; }
    }
}
