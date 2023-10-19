using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPractice
{
    public class InModifierExample
    {
        public static void InMethodExample(in Student aStudent)
        {
            //aStudent = new Student();  // this can not be done

            aStudent.Enrolled = true;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}
