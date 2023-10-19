using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePracticeExample
{
    public class DemoClassOne
    {
        public int AddTwoNumber(int numOne, int numTwo) => numOne + numTwo;
        public int MultiplyTwoNum(int numOne, int numTwo) => numOne * numTwo;
        public void Divide(double numOne, double numTwo)
        {
            double divisionResult;
            if (numOne > numTwo)
                divisionResult = numOne / numTwo;
            else if (numTwo > numOne)
                divisionResult = numTwo / numOne;
            else
                throw new DivideByZeroException("Can't divide by zero");
            Console.WriteLine("Division result is " + divisionResult);
        }

        public delegate int Calculation (int numOne, int numTwo);
       
    }
}
