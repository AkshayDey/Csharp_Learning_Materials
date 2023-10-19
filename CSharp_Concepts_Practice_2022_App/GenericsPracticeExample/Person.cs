using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeExample
{
    public class Person : IUser
    {
        public string Name 
        { 
            get; 
            set; 
        }

        public Person()
        {
            Name = "A Person";
        }
    }
}
