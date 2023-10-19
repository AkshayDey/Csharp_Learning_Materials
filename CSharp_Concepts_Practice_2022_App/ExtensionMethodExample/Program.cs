using ExtensionMethodExample;
using System.Net.Http.Headers;

//DemoClassBus aBus =  new DemoClassBus();
//aBus.Stop("Volvo Bus");
//aBus.Start();


//The main advantage of the extension method is to add new methods in the existing class without using inheritance.
//You can add new methods in the existing class without modifying the source code of the existing class.
//It can also work with sealed class.

//DemoClassCarSealed dCarSealed =  new DemoClassCarSealed();
//dCarSealed.EngineStarts();
//dCarSealed.EngineStops();

//string originalString = "hello world";
//(string stringPartA, string stringPartB) parts = originalString.Divide();
//Console.WriteLine("Part A is : "  + parts.stringPartA);
//Console.WriteLine("Part B is : " + parts.stringPartB);

Bottle aBottle =  new Bottle();
aBottle.ShapeOfBottle("Square");
aBottle.BuildMaterials();

// 12_Dec_2022
Demo aDemo = new Demo();
aDemo.DoSomething();
aDemo.DoSomethingAgain("message");
