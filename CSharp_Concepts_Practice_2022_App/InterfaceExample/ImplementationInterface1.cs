using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class ImplementationInterface1 : IInterface1
    {
        public void Add(int num1, int num2)
        {
            throw new NotImplementedException();
        }   
    }
}
