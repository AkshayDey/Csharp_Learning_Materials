using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipleExample.Abstraction
{
    public class Car : Vehicle
    {
        public override int numbers  // this code is for only test purpose
        { 
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }                       // this code is for only test purpose

        public override void Engine()
        {
            Console.WriteLine("Car Engine Starts");
        }

        public override void BrakeSystem()
        {
            Console.WriteLine("Car Brake System ");
        }

        public void AddSystem() // this is only for test purpose 
        {
            Console.WriteLine(numbers);
        }
    }
}
