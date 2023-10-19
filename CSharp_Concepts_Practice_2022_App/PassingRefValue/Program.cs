namespace PassingRefValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                Enrolled = false,
                Name = "Test",
            };

            PassingRefValue.Enroll(student);
        }
    }
}