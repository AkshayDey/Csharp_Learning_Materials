using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IInterface1
    {
        void Add (int num1, int num2);
    }

    public interface IInterface2 : IInterface1
    {
        //void Sub (int num1, int num2);

        public void Sub (int a, int b)
        {
            Console.WriteLine("This is purely a method inside Interface2 ");
        }
    }
}
