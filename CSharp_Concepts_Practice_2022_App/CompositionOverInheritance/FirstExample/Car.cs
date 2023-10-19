using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance.FirstExample
{
    public class Car
    {
        public string model { get; set; }
        public double speed { get; set; }
        public string color { get; set; }

        public void UpdateSpeed(double speed)
        {
            if (speed > 0)
            {
                speed += 10.00;
            }
        }

    }
}
