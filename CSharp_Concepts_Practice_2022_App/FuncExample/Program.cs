

using System.Data;

public class Program
{
    //delegate int Compare(int a, int b);


    //public static void Main()
    //{
    //    Compare c = Sum;
    //}

    //public static int Sum(int a, int b)
    //{
    //    return a + b;
    //}


    public void Test(Func<int,int,int>c)
    {

    }

    public int Something(int a, int b)
    {
        return a + b;
    }

    public void Main()
    {
        Test(Something);
    }
}


