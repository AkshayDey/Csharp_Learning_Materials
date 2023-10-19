using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipleExample.Abstraction
{
    public abstract class Vehicle
    {
        protected int myNumber;

        public abstract int numbers { get; set; }

        public abstract void Engine();

        public virtual void BrakeSystem()
        {
            
        }

        
    }
}
