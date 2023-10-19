using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IEngine
    {
        void Start();
        void Stop();

        string Model { get; set; }

        public double GetSpeed()  // Interface er Default Implementation
        {
            return 0;
        }


    }
}
