using EnumExample;

string option = Console.ReadLine();

Console.WriteLine((int)RegisterType.PassportNumber);

if (option == RegisterType.Name.ToString())
{
    Console.WriteLine();
}