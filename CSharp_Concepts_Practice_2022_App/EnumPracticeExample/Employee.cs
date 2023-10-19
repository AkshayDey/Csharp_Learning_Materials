using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPracticeExample
{
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        public Employee()
        {
            Name = "Akshay";
            EmployeeType = "Junior";
        }
    }
}
