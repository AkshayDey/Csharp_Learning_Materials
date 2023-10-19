using System.Reflection.Metadata.Ecma335;

delegate void Print(int value);
delegate int Calculate (int x, int y); 

class Program
{
    
    public static void Main(string[] args)
    {
       
        Print print = delegate (int value)
        {
            Console.WriteLine(value + 10);
        };

        Calculate calculate = delegate (int x, int y) // annonymous method can access delegate from outside of the class
        {
            return x * y;
        };
       

        int result = calculate(10,20);
        Console.WriteLine($"Result is {result}");

       //print(100);
    }
}
