using EnumPracticeExample;

Employee aEmployee = new Employee();
var input = Console.ReadLine();

if(input == EmployeeType.Junior.ToString())
{
    Console.WriteLine("Junior");
}
else
{
    Console.WriteLine("Others");
}
