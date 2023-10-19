using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Good_Design
{
    public class Manager : ITeamLeadTasks
    {
        public void AssignTask()
        {
            Console.WriteLine("Task Assigned");
        }

        public void CreateTask()
        {
            Console.WriteLine("Task Created");
        }
    }
    public class Programmer : IProgrammerTask
    {
        public void WorkOnTask()
        {
            Console.WriteLine("Started Working On the Task");
        }
    }
    public class TeamLead : ITeamLeadTasks, IProgrammerTask
    {
        public void AssignTask()
        {
            Console.WriteLine("Task Assigned");
        }

        public void CreateTask()
        {
            Console.WriteLine("Task Created");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Started Working On the Task");
        }
    }
}
