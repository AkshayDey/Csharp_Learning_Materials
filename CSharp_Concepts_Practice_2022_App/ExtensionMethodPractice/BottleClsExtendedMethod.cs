using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractice
{
    public static class BottleClsExtendedMethod
    {
        public static void ShapeOfMaterial(this Bottle bottle, string message)
        {
            Console.WriteLine(message);
        }
    }
}
