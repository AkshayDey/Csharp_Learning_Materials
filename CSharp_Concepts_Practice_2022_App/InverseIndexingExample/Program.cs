string[] fruits = { "Mango", "Jackfruits", "Banana", "Apple"};

Console.WriteLine("Before Inverse Indexing");
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine();
Console.WriteLine("After Inverse Indexing");

for(int i = 1; i <= fruits.Length; i++)
{
    Console.WriteLine(fruits[^i]);
}