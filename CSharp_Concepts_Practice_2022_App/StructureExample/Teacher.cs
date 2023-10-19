using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public class Teacher : Person
    { 
        public string Name { get; set; }
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
