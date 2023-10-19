using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamModifierExample_01
{
    public class ExampleClassOne
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;

        }

        public static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (var n in numbers)
            {
                result += n;
            }

            return result;

        }

        public static void RefernceMethod (ref int x)
        {
            x = 10;
        }

        public static void inMethod(in int x)
        {
            // can not be assigned
        }

        public static void outMethod(out int x) 
        {
            x = 10; // must initialize the variable
        
        }
    }
}
