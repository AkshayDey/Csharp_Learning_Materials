using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Bad_Design
{
    public class TeamLead : IEmployeeTasks
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateTask()
        {
            throw new NotImplementedException();
        }

        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }

    public class Manager : IEmployeeTasks
    {
        public void CreateTask()
        {
            Console.WriteLine("Task created.");
        }

        public void AssignTask()
        {
            Console.WriteLine("Task assigned.");
        }

        // The Manager client has been forced to implement `WorkOnTask()` method although Manager does not work on task.
        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }

       
    }

    public class Programmer : IEmployeeTasks
    {
        // The Programmer client has been forced to implement `CreateTask()` method although Programmer cannot create task.
        public void CreateTask()
        {
            throw new NotImplementedException();
        }

        // The Programmer client has been forced to implement `AssginTask()` method although Programmer cannot assign task.
        public void AssignTask()
        {
            throw new NotImplementedException();
        }
        public void WorkOnTask()
        {
            Console.WriteLine("Started working on the task.");
        }
    }
}
