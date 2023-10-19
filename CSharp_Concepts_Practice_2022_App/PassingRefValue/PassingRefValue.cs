using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingRefValue
{
    internal class PassingRefValue
    {
        public static void Enroll(Student student)
        {
            student.Enrolled = true;
            student = new Student();
            student.Enrolled = false;
        }

    }

    public class Student
    {     
        public string Name {  get; set; }       
        public bool Enrolled { get; set; }
    }
}
