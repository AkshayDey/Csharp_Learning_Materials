using System.Data;

int Sum(int a, int b) => a + b;


Func<double, double, double> m = (a, b) => a + b;

Console.WriteLine(m(2,3));