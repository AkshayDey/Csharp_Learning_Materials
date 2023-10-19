using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Starts ");
        }

        public override void Stop()
        {
            Console.WriteLine("Car Stops");
        }

        public override void GetSpeed()
        {
            Console.WriteLine("Speed is overridden");
        }
    }
}
