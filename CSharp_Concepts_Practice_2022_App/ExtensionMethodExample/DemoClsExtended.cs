using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class DemoClsExtended
    {
        public static void DoSomethingAgain(this Demo aDemo, string message)
        {
            Console.WriteLine($"DoSomethingAgain {message} ");
        }
    }
}
