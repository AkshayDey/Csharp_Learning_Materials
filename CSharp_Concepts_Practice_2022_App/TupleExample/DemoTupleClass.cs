using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    public class DemoTupleClass
    {

        public (int sum, int subtract) TupleDemoOne (int a , int b)
        {
            return (a + b, a - b);
        }
        //

    }
}
