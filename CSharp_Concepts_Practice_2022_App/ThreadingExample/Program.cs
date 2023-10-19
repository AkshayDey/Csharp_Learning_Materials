using ThreadingExample;
//Thread threadTwo = new Thread(() => PrintOddNum());  
//using ThreadingExample;

//Thread threadOne = new Thread(new ThreadStart(PrintEvenNum)); //Instead of line 2  try ThreadStart delegate
//threadOne.Start();
////threadOne.Suspend();
//Thread threadTwo = new Thread(new ThreadStart(PrintOddNum));
//threadTwo.Start();

//Console.ReadLine();

//void PrintEvenNum()
//{
//    for(int i =0; i < 50; i+=2)
//    {
//        Console.WriteLine(i);
//    }
//}
//void PrintOddNum()
//{
//    for(int i = 1; i < 50; i+=2)
//    {
//        Console.WriteLine(i);  
//    }
//}



Processing aProcessing = new Processing();
int r =  await aProcessing.Sum(2,2);
Console.WriteLine(r);
Console.ReadLine();