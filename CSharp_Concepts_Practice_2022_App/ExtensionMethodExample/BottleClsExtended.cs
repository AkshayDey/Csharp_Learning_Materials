using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    static class BottleClsExtended
    {
        public static void ShapeOfBottle (this Bottle aBottle, string msg)
        {
            Console.WriteLine("Bottle Shape is: " + msg );
        }
    }
}
