using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class QueryExecution
    {
        public void DeferredExecution()
        {
            // Sequence operators form first-class queries that
            // are not executed until you enumerate over them.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i =0;
            var q = from n in numbers
                    select ++i;

            foreach (var v in q) 
            {

                Console.WriteLine($"v = {v}, i = {i}");

            }
        }
    }
}
