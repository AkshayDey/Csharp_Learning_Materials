using System.Data;

namespace BasicDelegateExample
{
    public class Program
    {
        public delegate void DelegateOne(int a, int b);

        public static void Addition(int a, int b)
        {
            Console.WriteLine("Addition is : {0}", (a + b));
        }


        public static void Multiply(int p, int q)
        {
            Console.WriteLine("Multiplication is {0}", (p * q));
        }

        public static void Main(string[] args)
        {
            DelegateOne additionDelegate = Addition;
            DelegateOne multiplyDelegate = Multiply;
            DelegateOne composedDelegate = additionDelegate + multiplyDelegate;
            additionDelegate(12, 23);
            multiplyDelegate(12, 23);
            composedDelegate(12, 23);
        }

    }
}