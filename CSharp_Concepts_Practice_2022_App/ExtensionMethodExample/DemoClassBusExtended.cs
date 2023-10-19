using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    static class DemoClassBusExtended
    {
        public static void Stop(this DemoClassBus demoBus, string msg)
        {
            Console.WriteLine("Stops " + msg);
        }

        public static void Start(this DemoClassBus demoBus,string msg2)
        {
            //Console.WriteLine("Extension Demo Bus Started");
            demoBus.Start();
        }
    }
}
