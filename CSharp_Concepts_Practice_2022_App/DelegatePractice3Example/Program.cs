using DelegatePractice3Example;

#region for value type data

List<int> items = new List<int>()
{
    10, 20, 30,30,20,10
};

AnyNameClass<int> anyNameClassObj = new AnyNameClass<int>(items);


int CompareValues(int x, int y)
{
    if  (x == y) 
        return 0;
    else if (x < y) 
        return -1;
    else return 1;
}


anyNameClassObj.SortNumbers(CompareValues);

foreach (var allValues  in items)
{
    Console.Write(allValues);
    Console.Write(" ");
}

#endregion

#region reference type
//List <Person> persons =  new List<Person>()
//{
//    new Person() { Name = "A", Age = 30 },
//    new Person() { Name = "B", Age = 20 },
//    new Person() { Name = "C", Age = 30 },
//    new Person() { Name = "D",Age= 25 }
//};

//int ComparePersonsAge(Person x, Person y )
//{
//    if(x.Age > y.Age)
//        return 1;
//    else
//        return -1;
//}

//AnyNameClass<Person> anyNameClassObj = new AnyNameClass<Person>(persons);

//anyNameClassObj.SortNumbers(ComparePersonsAge);


//foreach(var allAgesinPersons in persons)
//{
//    Console.WriteLine($"Name : {allAgesinPersons.Name}, Ages : {allAgesinPersons.Age}");
//}

#endregion