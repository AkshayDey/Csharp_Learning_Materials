using LinqExample;
using LinqExample.DataSources;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

int[] numbers = new int[] { 12, 34, 23, 23, 12, 34, 32 };


decimal[] dNumbers = { 2.233m, 7.90m, 8.90m };

var dResults = from d in dNumbers where d > 5 select d;

//foreach (var allItems  in dResults)
//{
//    Console.WriteLine(allItems);
//}

//int countNumbers = numbers.Count();
//int l =numbers.Length;
//Console.WriteLine(countNumbers);

//int[] results =  (from n in numbers where n % 2 == 0 select n).ToArray();
//foreach (var allItems in results)
//{
//    Console.WriteLine(allItems);
//}

//Orders[] Orders = new Orders[3];
//Orders[0] =  new Orders { OrderId = 1 , OrderName = "Vegetables" };
//Orders[1] = new Orders { OrderId = 2, OrderName = "Fruits" };
//Orders[2] = new Orders { OrderId = 3, OrderName = "Meats" };

//Person[] persons = new Person[3];
//persons[0] = new Person { PersonId = 1, Name = "NameOne" };
//persons[1] = new Person { PersonId = 2, Name = "NameTwo" };
//persons[2] = new Person { PersonId = 1, Name = "NameThree" };


////"select p.name, o.OrderName from persons p join Orders o on p.PersonId = o.OrderId "

//var allresults = from o in Orders join p in persons on o.OrderId equals p.PersonId select (p.Name, o.OrderName);

//foreach (var allRecords in allresults)
//{
//    Console.WriteLine("Person is : " + allRecords.Name + " Order is : " + allRecords.OrderName);
//}

//>> AggregateOperators
#region CountSyntax
//int[] factorsOf300 = { 2, 2, 3, 5, 5 };

//int uniqueFactors = factorsOf300.Distinct().Count();
//Console.WriteLine($"There are {uniqueFactors} unique factors of 300");
#endregion

Console.WriteLine("-----------------------------------------");
#region CountConditional
int[] num = { 23, 34, 12, 10, 14, 15 };

//int[] evenNumbers = (from n in num where n % 2 == 0 select n).ToArray();

//foreach (var allItems in evenNumbers)
//{
//    Console.WriteLine(allItems);
//}

//var firstThreeBiggestNum = (from n in num orderby n descending select n).Take(3);

//Console.WriteLine("Three biggest num are :  ");
//foreach(var allThreeItems in firstThreeBiggestNum)
//{
//    Console.WriteLine( allThreeItems);
//}

var averageOfNum = (from n in num select n).Average();

Console.WriteLine("Average of Num is " + averageOfNum);


 #endregion

#region GroupedCount

Products aProducts =  new Products();

List<Products> listOfProducts = aProducts.SetProducts();
var resultedProducts = from p in listOfProducts
                       group p by p.Category into g
                       select (ProductCount: g.Count(), Category: g.Key);
foreach (var c in resultedProducts)
{
    Console.WriteLine($"Product Category : {c.Category}, Product Count:  {c.ProductCount}");
}
#endregion

#region MinProjection
string[] products = {"Cheese", "Fruits","Vegetables","Pop" };
//string[] sortedProducts = new string[products.Length];
string maxWord;
string minWord;
int minProduct = products.Min(w => w.Length);

//for(int i = 0; i < products.Length; i++)
//{
//    if (products[i].Length > products[i+1].Length)
//    {
//        resultP = products[i];
//    }

//}

//sortedProducts = products.OrderBy(x => x.Length).ToArray();

var sortedProducts = (from p in products orderby p.Length ascending select p).ToArray();
Console.WriteLine("Smallest Word : {0}", sortedProducts[0]);
Console.WriteLine("Largest Word : {0}", sortedProducts[sortedProducts.Length - 1]);

Console.WriteLine(minProduct);
#endregion
