using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOneExample.Problem_1
{
    public class Students
    {
        public string Name { get; set; }
        public string CourseName { get; set; }

    }

    public static class AllStudents
    {
        public static List<Students> listOfStudents = new List<Students>()
        {
            new Students() { Name = "A", CourseName= "C" },
            new Students() { Name = "V", CourseName= "C++" },
        };

    }

    
}
