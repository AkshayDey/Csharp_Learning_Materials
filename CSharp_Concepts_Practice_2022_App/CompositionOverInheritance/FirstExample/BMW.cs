using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance.FirstExample
{
    public class BMW
    {
        public string color { get; set; }

        private Car aCar; // creating compostion

        public BMW(string _model, double _speed, string _color)
        {
            this.aCar = new Car() { model = _model, speed = _speed };
            color = _color;
        }

        public void GetBMWCarValues()
        {
            Console.WriteLine(aCar.model);
            Console.WriteLine(aCar.speed);
            Console.WriteLine(color);
        }

    }
}
