using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParamModifierExample
{
    public class ParamExampleOne
    {

        int x = 10;
        public void ShowString(params object[] ListNumbers)
        {
            //int result = 0;
            for (int i = 0; i < ListNumbers.Length; i++)
            {  
                Console.WriteLine(ListNumbers[i]);
            }

        }

        public void Test(ref int x)
        {
            Console.WriteLine("The value of x is {0}", x);
        }
        
        public void Test2(in int x1)
        {
            Console.WriteLine(x1);
        }

        public void Test3 (out int x2)
        {
            x2 = 100;
            Console.WriteLine(x2);
        }
    }
}
