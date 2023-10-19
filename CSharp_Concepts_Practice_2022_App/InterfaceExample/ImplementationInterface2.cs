using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class ImplementationInterface2 : IInterface2
    {
        public void Add(int num1, int num2)
        {
            int summation = num1 + num2;
            Console.WriteLine("Summation result is {0}", summation);
        }

        //public void Sub(int num1, int num2)
        //{
        //    int sub;
        //    if (num1 > num2)
        //    {
        //        sub = num1 - num2;
        //    }
        //    else
        //        sub = num2 - num1;
        //    Console.WriteLine("Subtraction result is {0}", sub);
        //}
    }
}
