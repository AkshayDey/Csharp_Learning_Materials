using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct Student : IPerson
    {
        public string Name { get; set; }
        private int id;
        public int Id
        {
            get 
            { 
                return id; 
            }
            set
            {
                id = value;
            }
        }

        public Student(int id) // parametertized const
        {
            this.id = id;
            Name = string.Empty;
        }

        public Student()
        {
            id = 0;
            Name = string.Empty;
        }

        public void Talk(string message)
        {
            throw new NotImplementedException();
        }
    }
}
