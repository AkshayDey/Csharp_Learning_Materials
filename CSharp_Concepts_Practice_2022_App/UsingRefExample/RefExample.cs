using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefPractice
{
    public class RefExample
    {
        public static void Enroll(ref Student student)
        {
            // With ref, all three lines below alter the student variable outside the method.
            student.Enrolled = true;
            student = new Student();
            student.Enrolled = false;
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}
