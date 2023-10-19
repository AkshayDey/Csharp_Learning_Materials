using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Example
{
    public class Class2 : IClass
    {
        public void DoSomething(object o)
        {
            Console.WriteLine(o);
        }

        public void Start(object o)
        {
            DoSomething(o);
        }
    }
}
