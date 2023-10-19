//using RecursionExample;

//int fact, num;
//Console.WriteLine("Enter num: ");
//num = Convert.ToInt32(Console.ReadLine());
//factorialClass objFactClass = new factorialClass();
//fact = objFactClass.factorial(num);
//Console.WriteLine("Factorial of {0} is {1}", num, fact);

class Program
{
    public static int factorial(int num)
    {
        if (num == 0)
            return 1;
        else
            return num * factorial(num - 1);
    }

    public static void Main(string[] args)
    {
        int fact, num;
        Console.WriteLine("Please enter num:  ");
        num = Convert.ToInt32(Console.ReadLine());
        fact = num * factorial(num - 1);
        Console.WriteLine("Factorial of {0} is {1}", num, fact);

    }
}

