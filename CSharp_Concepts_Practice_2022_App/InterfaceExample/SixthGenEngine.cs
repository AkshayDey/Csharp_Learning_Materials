using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class SixthGenEngine : FifthEngine
    {
       
        public override void IncreaseSpeed(int t)
        {
            Console.WriteLine("Speed has increased in Sixth Gen Engine");
        }

    }
}
