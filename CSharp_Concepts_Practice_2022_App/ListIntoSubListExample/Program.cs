List<string> persons = new() { "A", "B", "C", "D", "E" };
var names = persons.Chunk(2);
var i = 0;
foreach (var allNames in names)
{
    //Console.WriteLine($"List{i}: {allNames[i]}");
    //i++;

    foreach (var eachitem in allNames)
    {
        Console.WriteLine($"List{i}: {eachitem[i]}");
    }
}