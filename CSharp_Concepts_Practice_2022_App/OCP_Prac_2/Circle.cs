using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Prac_2
{
    public class Circle: Shape
    {
        public double radius { get; set; }
        public Circle(double _radius)
        {
            radius = _radius;
        }

        public override double GetArea() =>  Math.PI* radius * radius;
        
    }
}
