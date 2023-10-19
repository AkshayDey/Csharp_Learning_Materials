using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Bad_Design
{
    public interface IEmployeeTasks
    {
        void CreateTask();
        void AssignTask();
        void WorkOnTask();
    }
}
