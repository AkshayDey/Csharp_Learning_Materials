using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Prac_2
{
    public class Rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        
        public override double GetArea() => length * width;
       
    }
}
