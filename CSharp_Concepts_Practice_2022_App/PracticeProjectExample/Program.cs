
using System.Net.Http.Headers;

class Program
{
    public static void Main(string[] args)
    {
        var StudentOne = new Student { Name = "Akash", Age = 23 };
        var StudentTwo = new Student { Name = "Abir", Age = 44};

        List<Student> allStudents = new List<Student> { StudentOne, StudentTwo };

        foreach (var allItems in allStudents)
        {
            Console.WriteLine("Name is " + allItems.Name + " and Age is " + allItems.Age);
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

}