using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    static class DemoClassCarSealedExtended
    {
        public static void EngineStops(this DemoClassCarSealed dCarSealed)
        {
            Console.WriteLine("Car(Sealed) Engine Stops");
        }
    }
}
