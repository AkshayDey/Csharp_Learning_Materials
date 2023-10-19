

using System.Reflection;

dynamic item = new { Name = "Jahid", Age = 41 };
Console.WriteLine(item.Name);

dynamic item2 = GetObject();

//object aObject = new { Color = "Black", Age = 50 };
//Type t = aObject.GetType();
//PropertyInfo pInfo = t.GetProperty("Age");
//Console.WriteLine(pInfo.GetValue(aObject));

object objectItem = new { Adrress = "a", Salary = 434 };
Type t = objectItem.GetType();
PropertyInfo p1 = t.GetProperty("Salary");
Console.WriteLine(p1.GetValue(objectItem));

object GetObject()
{
    return new { Adrress = "a", Salary = 434 };
}
