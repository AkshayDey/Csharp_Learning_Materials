using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOneExample.Problem_1
{
    public class ProblemOneOperator
    {
        public List<Students> GetAllStudents()
        {
            return AllStudents.listOfStudents;
        }

        public void GetAllStudentInformation()
        {
            List<Students> studentsList = GetAllStudents();

            var result = from s in studentsList
                         select (StudentName: s.Name, CourseName: s.CourseName);

            foreach (var allItems in result)
            {
                Console.WriteLine($"{allItems.StudentName}, {allItems.CourseName}");
            }
        }

    }
}
