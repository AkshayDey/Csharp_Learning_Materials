namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackClass<string> stackClass = new StackClass<string>();

            stackClass.Add("a");
            stackClass.Add("b");
            stackClass.Add("c");
            stackClass.Add("d");
            
            Console.WriteLine("Popped Out Item {0}", stackClass.pop());
            Console.WriteLine("Peek Item {0}", stackClass.Peek());
            Console.WriteLine("Popped Out Item {0}", stackClass.pop());
            Console.WriteLine("Peek Item {0}", stackClass.Peek());
            Console.WriteLine("Popped Out Item {0}", stackClass.pop());

            //Console.WriteLine("Popped Out Item {0}", stackClass.pop());



        }
    }
}