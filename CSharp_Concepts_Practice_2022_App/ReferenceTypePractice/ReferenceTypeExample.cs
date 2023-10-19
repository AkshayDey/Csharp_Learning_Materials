using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypePractice
{
    public class ReferenceTypeExample
    {
        public static void  ExampleMethod(Student aStudent)
        {
            aStudent.Enrolled = true; // This changes the student variable that was passed in outside of the method.
            aStudent = new Student(); // This does not change the student variable outside of the method but creates a new reference. Since student now points to a new reference, the student variable outside of the method is no longer affected after this line.
            aStudent.Enrolled = false; // This changes the local student inside the method.

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }

        public Student() 
        {
            Name = "H";
            Enrolled = false;
        }
    }

}
