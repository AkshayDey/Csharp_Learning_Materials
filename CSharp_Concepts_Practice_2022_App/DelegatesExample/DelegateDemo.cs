using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class DelegateDemo
    {
        public delegate int DemoDelegateExample(int a, int b); // parameters
        public delegate string BasicDelegate(int a, int b);
        
        public double DoSum (DemoDelegateExample delegateExample)
        {
            return delegateExample(10, 20); // arguments 
        }

        public string Add(int arg1, int arg2)
        {
            return (arg1 + arg2).ToString();
        }




        // creating a composed delegate

    }
}
