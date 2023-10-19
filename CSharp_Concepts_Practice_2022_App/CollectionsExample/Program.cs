using System.Collections;
using System.Net.Http.Headers;

//List<int> aList = new List<int>();
//aList.Add(1);
//aList.Add(2);
//aList.Add(3);

//Dictionary<int, string> aDictionary = new Dictionary<int, string>();

//aDictionary.Add(1, "Akshay");
//aDictionary.Add(2, "Habib");

//aDictionary[3] = "Ahsan";

//foreach (var allItems in aDictionary)
//{
//    Console.WriteLine("Values {0}", allItems.Value);
//    Console.WriteLine("keys {0}", allItems.Key);
//}

// Hashset 


//HashSet<string> aHashSet = new HashSet<string>();
//aHashSet.Add("Akash");
//aHashSet.Add("Azad");
//aHashSet.Add("Abir");
//aHashSet.Add("Abdul");

//HashSet<string> bHashSet = new HashSet<string>();
//bHashSet.Add("Akash");
//bHashSet.Add("Azam");
//bHashSet.Add("Azad");
//bHashSet.Add("Akter");

//aHashSet.UnionWith(bHashSet);
//foreach (var allItems in aHashSet)
//{
//    Console.WriteLine(allItems);
//}
//int countOfAllItems = aHashSet.Count();
//Console.WriteLine(countOfAllItems);

LinkedList<int> aLinkedList = new LinkedList<int>();
aLinkedList.AddFirst(100);
aLinkedList.AddLast(23);
LinkedListNode<int> node = aLinkedList.Find(100);
aLinkedList.AddAfter(node, 150);

Console.WriteLine("----------------LinkedList-------------------");
foreach (var allLinkedListItems in aLinkedList)
{
    Console.WriteLine(allLinkedListItems);
}

//Console.WriteLine("----------------PriorityQueue-------------------");

//PriorityQueue<double, int> aPriorityQueue = new PriorityQueue<double, int>();
//aPriorityQueue.Enqueue(1223.34, 2);
//aPriorityQueue.Enqueue(200.34, 1);

//Console.WriteLine(aPriorityQueue.Dequeue());


//Console.WriteLine("----------------Queue-------------------"); // FIFO

//Queue<int> queueValues = new Queue<int>();
//queueValues.Enqueue(112);
//queueValues.Enqueue(20);
//queueValues.Enqueue(30);
//queueValues.Enqueue(40);
//queueValues.Enqueue(50);
//queueValues.Enqueue(100);


//try
//{
//    while (queueValues.Count > 0)
//    {
//        Console.WriteLine(queueValues.Dequeue());
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Stack<int> aStackValues = new Stack<int>();
//aStackValues.Push(100);
//aStackValues.Push(200);
//aStackValues.Push(300);
//aStackValues.Push(400);
//aStackValues.Push(500);


//Console.WriteLine("----------------Stack-------------------");

//while (aStackValues.Count > 0 )
//{
//    Console.WriteLine(aStackValues.Pop()); // LIFO
//}

//Console.WriteLine("----------------Sorted List-------------------");

//SortedList<int, string> aSortedList = new SortedList<int, string>();

//aSortedList.Add(13, "Hello");
//aSortedList.Add(2, "C#");

//foreach (var allItems in aSortedList)
//{
//    Console.WriteLine(allItems.Value);
//}


////Non Generic Collections

//ArrayList aArrayList = new ArrayList();
//aArrayList.Add("Dhaka");
//aArrayList.Add(123);


//Console.WriteLine("---------------- Array List -------------------");
//foreach (var allItems in aArrayList)
//{
//    Console.WriteLine(allItems) ;
//}


