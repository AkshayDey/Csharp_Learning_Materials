using DelegateTwoExample;
using System.Data;
using System.Net.Http.Headers;

//class program
//{
//    public delegate int DelegateOne(int a, int b);

//    static void Main(String[] args)
//    {
//        //DelegateOne delegateOne;

//        //delegateOne = Add;
//        //Console.WriteLine("Delegate Summation is {0}", delegateOne(10,10));
//        //delegateOne = Sub;
//        //Console.WriteLine("Delegate Subtraction is {0}", delegateOne(20,10));
//        //static int Add(int a, int b)
//        //{
//        //    return a + b;
//        //}

//        //static int Sub(int a, int b)
//        //{
//        //    if (a > b)
//        //    {
//        //        return a - b;
//        //    }
//        //    else
//        //        return b - a;
//        //}

//        Func<int, int, int> functionOne;

//        functionOne = Sum;
//        Console.WriteLine("Func Sum is {0}", functionOne(10,23));

//        static int Sum(int a, int b) => a + b;

//        static int Sub (int a, int b)
//        {
//            if (a > b)
//                return a - b;
//            else
//                return b - a;
//        }
//    }

//}

Member[] members = 
{
    new Member { Id = 1, Name = "A", City = "India"},
    new Member { Id = 2, Name = "B", City = "Thailand"},
    new Member {Id = 3, Name = "C", City = "Bangladesh"}
};

Console.WriteLine(members.Count());
//Func<Member, bool> funcMember = m => m.Id == 3;  // lambda expression

//var result = members.Where(funcMember);
//foreach(var allItems in result)
//{
//    Console.WriteLine(allItems.City);
//}

