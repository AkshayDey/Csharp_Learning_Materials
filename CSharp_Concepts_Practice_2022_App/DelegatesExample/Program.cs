using DelegatesExample;
using System.Net.Http.Headers;
using static DelegatesExample.DelegateDemo;




//DoSum aDoSum = new DoSum(aBubbleSort.Sum);
//DoSubtract aDoSubtract = new DoSubtract(aBubbleSort.Subtract);

//Console.WriteLine(aDoSum(100, 23));
//aDoSubtract(100,23);

#region previous code
int CompareValue(int a, int b)
{
    if (a == b)
    {
        return 0;
    }
    else if (a > b)
    {
        return -1;
    }
    else
        return 1;
}


List<int> ages = new List<int>();
ages.Add(23);
ages.Add(33);
ages.Add(25);
ages.Add(20);
ages.Add(40);

BubbleSort<int> aBubbleSort = new BubbleSort<int>(ages);

aBubbleSort.Sort(CompareValue);

foreach (var allAges in ages)
{
    Console.WriteLine(allAges);
}

//int ComparePerson(Person a, Person b)
//{
//    if (a.Age == b.Age)
//    {
//        return a.Name.CompareTo(b.Name);
//    }
//    else if (a.Age > b.Age)
//    {
//        return 1;
//    }
//    else
//        return -1;
//}

//List<Person> aPerson = new List<Person>();
//aPerson.Add(new Person { Name = "Abdul", Age = 24 });
//aPerson.Add(new Person { Name = "Akash", Age = 26 });
//aPerson.Add(new Person { Name = "Azad", Age = 34 });
//aPerson.Add(new Person { Name = "AsimAbdulAliMohajon", Age = 27 });
//aPerson.Add(new Person { Name = "AbdulAli", Age = 27 });

//BubbleSort<Person> personSort = new BubbleSort<Person>(aPerson);
//personSort.Sort(ComparePerson);

//foreach (var allItems in aPerson)
//{
//    Console.WriteLine($"Name : {allItems.Name}, Age : {allItems.Age}");
//}
#endregion

#region new code 13_Nov_2022
DelegateDemo aDelegateDemo = new DelegateDemo();

int Sum(int a, int b)
{
    return a + b;
}

double result = aDelegateDemo.DoSum(Sum);
Console.WriteLine("Result of Delegate Sum is {0}", result);


#endregion


#region code 15 Nov 2022
BasicDelegate aBasicDelegate;
aDelegateDemo.Add(23, 34);

#endregion