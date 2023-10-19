using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPractice
{
    public class OutExample
    {
        public static void OutMethod (out Student aStudent)
        {
            aStudent = new Student();
            aStudent.Enroll = false;     

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enroll { get; set; }
    }
}
