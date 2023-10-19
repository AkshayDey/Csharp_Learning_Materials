class Program
{
    public static (int sum, int multiply) DoCalculation (int x, int y)
    {
        return (x + y, x * y);
    }

    public static void Main ()
    {
        var result = DoCalculation (100, 200);
        //Console.WriteLine("Summation result is " + result.sum);
        //Console.WriteLine("Multiplication result is " + result.multiply);


        // class based approach
        //Tuple<string, int> TupleOne = new Tuple<string, int>("Hello Tuple", 23);
        //Tuple<int, int, int, int, int, int, int, Tuple<int>> anotherTuple = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 3, 4, 5, 6, 7, 8, new Tuple<int>(8));
        //Tuple<int, int, Tuple<int>> aTuple = new Tuple<int, int, Tuple<int>>(1, 3, new Tuple<int>(10));
        //Console.WriteLine(anotherTuple);
        //Console.WriteLine(TupleOne);


        // Method based tuple

        var MethodOneTuple = Tuple.Create ("StringOne",2332);
        var MethodTwoTuple = Tuple.Create("Hello", 23232, Tuple.Create("Hello Again"));
        Console.WriteLine("Method Two Tuple is " + MethodTwoTuple.Item3);
    }
} 