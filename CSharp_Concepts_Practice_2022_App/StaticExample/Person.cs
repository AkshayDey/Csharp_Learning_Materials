using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public class Person
    {
        public  string Name { get; set; }
        public static int Count;

        public void Calculate()
        {
            Count++;
        }
        public static void Calculate2(string message)
        {
            Count++;
        }
    }
}
