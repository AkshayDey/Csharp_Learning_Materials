using DelegatePracticeExample;
using static DelegatePracticeExample.DemoClassOne;

DemoClassOne aCalculation = new DemoClassOne();

Func<int,int,int> funcAdd = aCalculation.AddTwoNumber;
Calculation delegateMultiply = aCalculation.MultiplyTwoNum;
Action<double, double > actionDivision = aCalculation.Divide;

var add  = funcAdd(12, 42);
var resultMultiply = delegateMultiply(100,34);
actionDivision(100, 23);


Console.WriteLine("Addition result is " + add);
Console.WriteLine("Multiplication result is " + resultMultiply);