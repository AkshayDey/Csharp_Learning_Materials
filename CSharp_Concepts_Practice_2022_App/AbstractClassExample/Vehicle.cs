using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public abstract void Start();
        public abstract void Stop();

        public virtual void GetSpeed()
        {
            
        }

    }
}
