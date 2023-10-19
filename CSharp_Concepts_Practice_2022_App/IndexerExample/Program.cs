using IndexerExample;

//Storage aStorage = new Storage(5);

//aStorage.Add(7);
//aStorage.Add(8);
//aStorage.Add(9);

//aStorage[1] = 10;
//Console.WriteLine(aStorage[2]);

//IndexerClass aIndexerClass = new IndexerClass(4);
//aIndexerClass.names[0] = "A";
//aIndexerClass.names[1] = "B";
//aIndexerClass.names[2] = "C";
//aIndexerClass.names[3] = "D";


//for(int i =0; i <aIndexerClass.names.Length; i++)
//{
//    Console.WriteLine(aIndexerClass.names[i]);
//}

IndexerClssWithMethodOverloading aIndexerClass = new IndexerClssWithMethodOverloading(5);
Console.WriteLine("Indexer with Integer Type");
aIndexerClass.nameString[0] = "AbduL aziz";
aIndexerClass.nameString[1] = "Akshay Dey Shovo";
aIndexerClass.nameString[2] = "Julfikar Ahmed";

for (int i = 0; i < aIndexerClass.nameString.Length; i++)
{
    Console.WriteLine(aIndexerClass.nameString[i]);
}
Console.WriteLine();
Console.WriteLine("Indexer with String Type");
Console.WriteLine(aIndexerClass["AbduL aziz"]);
Console.WriteLine(aIndexerClass["Akshay Dey Shovo"]);
Console.WriteLine(aIndexerClass["Julfikar Ahmed"]);
