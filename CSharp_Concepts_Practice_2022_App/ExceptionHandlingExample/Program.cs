using ExceptionHandlingExample;



int[] num = new int[] { 10, 30, 34, 32 };
//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine($"num[{i}] value: [{num[i]}]");
//}

//Console.WriteLine(num[4]);

//try
//{
//    Console.WriteLine(num[4]);
//}
//catch (Exception ex) 
//{

//    Console.WriteLine("Exception message is :    " +ex.Message);
//}

try
{
    CourseManagement aCourseManagement = new CourseManagement();
    aCourseManagement.AddCourses("C#");
}
catch (DuplicateException de)
{
    Console.WriteLine(de.Message);
}
catch (Exception ex)
{
    Console.WriteLine("There was a problem  "  + ex.Message);
}



