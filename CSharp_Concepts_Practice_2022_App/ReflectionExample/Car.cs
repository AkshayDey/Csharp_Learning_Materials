using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Car
    {
        public int Speed { get; set; }
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }
        public void Start()
        {
            Console.WriteLine("Car Starts");
        }
        public void Stop()
        {
            Console.WriteLine("Car Stops");
        }
    }
}
