using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipleExample.Abstraction
{
    public class Consultant : IEnroller
    {
        public string GetCId()
        {
            return "C-" + new Random(DateTime.Now.Second).Next().ToString();
        }

        public string PrepareId()
        {
           return GetCId();
        }

        public void ProcessId(string id)
        {
            Console.WriteLine("Consultant Enrolled");
        }
    }
}
