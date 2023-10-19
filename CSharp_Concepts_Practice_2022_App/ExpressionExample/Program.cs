//Func<int,int,int> result = 

using System.Security.Cryptography.X509Certificates;

public class program
{

    public static int DoSum(int a, int b)
    {
        return a + b;
    }
    public static void main()
    {
        int v = DoSum(10, 239);
        Func<int, int, int> result = v;
    }
}

