using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypePractice
{
    public class ValueTypeExample
    {
        public static void ValueTypeMethod(bool enrollmentStatus)       
        {
            // This will not change any value outside the method.
            enrollmentStatus = true;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }

        public Student() 
        {
            Name = "HA";
            Enrolled = false;
        }
    }
}
