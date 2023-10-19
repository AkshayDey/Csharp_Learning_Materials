using TupleExample;

DemoTupleClass aDemoTupleClass = new DemoTupleClass();
(int Sum, int Subtract) result = aDemoTupleClass.TupleDemoOne(20, 10);

//Console.WriteLine("Sum is {0}", result.Sum);
//Console.WriteLine("Sub is {0}", result.Subtract);



(int X, int Y) Point = (10, 23);

//Console.WriteLine(Point.X);
//Console.WriteLine(Point.Y);

Customer[] customers = new Customer[3];
customers[0] = new Customer { CusId = 1, CustomerName = "John", OrderId = 1 };
customers[1] = new Customer { CusId = 2, CustomerName = "Jack", OrderId = 2 };
customers[2] = new Customer { CusId = 3, CustomerName = "William", OrderId = 3 };

Order[] Orders = new Order[3];
Orders[0] = new Order { Id = 1, OrderName = "Fruits" };
Orders[1] = new Order { Id = 2, OrderName = "Vegetables" };
Orders[2] = new Order { Id = 3, OrderName = "Meats" };

var results = from c in customers join o in Orders on c.OrderId equals o.Id
              select (CustomerName : c.CustomerName, OrderName: o.OrderName); 

//foreach(var allItems in results)
//{
//    Console.WriteLine("{0} has ordered {1}", allItems.CustomerName, allItems.OrderName);
    

//}
// nested tuple

(int numOne, (string a, double p)) nestedTuple = (232, ("s", 23.34));
Console.WriteLine(nestedTuple.Item2.p + nestedTuple.Item1);

