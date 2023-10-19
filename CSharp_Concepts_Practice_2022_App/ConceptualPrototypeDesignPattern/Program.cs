using ConceptualPrototypeDesignPattern;

Person p1 = new Person();
p1.Age = 42;
p1.BirthDate = Convert.ToDateTime("1977-01-01");
p1.Name = "Jack Daniels";
p1.IdInfo = new IdInfo(666);

Person p2 = p1.ShallowCopy();
Person p3 = p1.DeepCopy();

// Display values of p1, p2 and p3.
Console.WriteLine("Original values of p1, p2, p3:");
Console.WriteLine("   p1 instance values: ");
Person.DisplayValues(p1);
Console.WriteLine("   p2 instance values:");
Person.DisplayValues(p2);
Console.WriteLine("   p3 instance values:");
Person.DisplayValues(p3);


// Change the value of p1 properties and display the values of p1,
// p2 and p3.
p1.Age = 32;
p1.BirthDate = Convert.ToDateTime("1900-01-01");
p1.Name = "Frank";
p1.IdInfo.ID = 7878;
Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
Console.WriteLine("   p1 instance values: ");
Person.DisplayValues(p1);
Console.WriteLine("   p2 instance values (reference values have changed):");
Person.DisplayValues(p2);
Console.WriteLine("   p3 instance values (everything was kept the same):");
Person.DisplayValues(p3);