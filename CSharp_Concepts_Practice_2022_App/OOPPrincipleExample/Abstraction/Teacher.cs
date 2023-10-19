using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipleExample.Abstraction
{
    public class Teacher :IEnroller
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GenerateId()
        {
            return "T-" + new Random(DateTime.Now.Second).Next().ToString();
        }

        public string PrepareId()
        {
           return GenerateId();
        }

        public void ProcessId(string id)
        {
            Console.WriteLine("Teacher Enrolled");
        }
    }
}
