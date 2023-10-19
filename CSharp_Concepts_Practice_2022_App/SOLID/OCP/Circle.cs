using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Circle : Shape
    {
        private double _area;
        public Circle(double area)
        {
            _area= area;
        }
        public override double CalculateArea()
        {
            return (Math.PI * _area * _area);
        }
    }
}
