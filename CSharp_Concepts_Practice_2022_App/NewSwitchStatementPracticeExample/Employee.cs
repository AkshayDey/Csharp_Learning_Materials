using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSwitchStatementPracticeExample
{
    public class Employee
    {
        public string EmpName { get; set; }
        public EmployeeStatus EmpStatus { get; set; }
     
    }

    public enum EmployeeStatus
    {
        Present,
        Absent,
        Senior,
        Junior
    }

    
}
