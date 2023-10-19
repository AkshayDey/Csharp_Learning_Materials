using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegt_Prac_2_Example
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public float Experience { get; set; }

        public delegate bool delegateIsEmp(Employee emp);

        public void Promoted (List<Employee> empList, delegateIsEmp adelegateEmp)
        {
            foreach(Employee emp in empList)
            {
                if(adelegateEmp(emp))
                {
                    Console.WriteLine("Employee {0} is Promoted", emp.Name);
                }
            }
        }
        
    }

}
