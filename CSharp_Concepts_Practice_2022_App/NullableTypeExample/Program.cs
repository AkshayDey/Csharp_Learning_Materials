// nullable type

int? x = null;

string? y = null;

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
else
{
    Console.WriteLine("The value is null");
}

if (string.IsNullOrEmpty(y) == false)
{
    Console.WriteLine(y);
}
else
{
    Console.WriteLine("String is Empty");
}