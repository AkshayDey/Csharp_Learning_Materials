public delegate int CalculateDelegate(int a, int b);
class Program
{
    
    public static void Main(string[] args)
    {
        CalculateDelegate delegateOne = delegate (int x, int y) // annonymous method
        {
            return x * y;
        };

        int resultDelegate = delegateOne(12, 12);

        Console.WriteLine(resultDelegate);

    }

}
