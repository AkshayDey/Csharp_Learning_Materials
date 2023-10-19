using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractice
{
    public static class BottleNewExtended
    {
        
        public static void BottleLabelColor(this BottleNew bottleNew, string message)
        {
            Console.WriteLine(message);
        }
    }
}
