using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionOverInheritance.SecondExample
{
    public class PrototypeOneCar
    {
        public string color { get; set; }

        private Engine engine;  //creating composition

        public PrototypeOneCar()
        {
            this.engine = new Engine();

        }

        public void PrototypeEngineStarts()
        { 
            engine.EngineStart();

        }
    }
}
