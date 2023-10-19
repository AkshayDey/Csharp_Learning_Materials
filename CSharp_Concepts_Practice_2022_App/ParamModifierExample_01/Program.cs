using ParamModifierExample_01;

int[] inputNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

ExampleClassOne.Sum(10, 23, 34);
int resultedOutput = ExampleClassOne.Sum(inputNumbers);
//Console.WriteLine(resultedOutput);

int x = 200;
ExampleClassOne.RefernceMethod(ref x);
ExampleClassOne.inMethod()   