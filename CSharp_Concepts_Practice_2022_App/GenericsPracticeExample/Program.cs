
using GenericsPracticeExample;

public class Point<T, V>
{
    public T x { get; set; }
    public V y { get; set; }

    public void showValues()
    {
        Console.WriteLine("Value of X is " + x);
        Console.WriteLine("Value of Y is " + y);
    }
}

public class SuperPoint <A,B,C> : Point <A,B>
{
    public C z { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        Point<int, string> aPoint = new Point<int, string>();
        SuperPoint<int, int, string> aSuperPoint = new SuperPoint<int, int, string>();
        SecuritySystem<Person> aSecuritySystem = new SecuritySystem<Person>();

        aPoint.x = 100;
        aPoint.y = "hello generics";
        aPoint.showValues();
        Console.WriteLine("-----------------");
        aSuperPoint.x = 1000;
        aSuperPoint.y = 200000;
        aSuperPoint.z = "hello again from superclass";

        aSuperPoint.showValues();
        Console.WriteLine("Value of Z is " + aSuperPoint.z);

        aSecuritySystem.showFullName();    
    }
}