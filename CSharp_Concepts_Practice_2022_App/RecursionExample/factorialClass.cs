using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionExample
{
    public class factorialClass
    {
        public int factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            else
            {
                return num * factorial(num - 1);
            }

        }
    }
}
