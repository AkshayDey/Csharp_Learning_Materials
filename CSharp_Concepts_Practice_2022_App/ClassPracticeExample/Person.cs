using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeExample
{
    public class Person
    {
        private string name;
        public readonly int valueOne;
        public string Name  // property
        {
            get
            {
                return name;

            }

            set
            {
                if (name != null)
                name = value;
                else
                    name = string.Empty;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Address { get; set; }  // Auto Property
        
        public Person(int valueOne)
        {
            this.valueOne = valueOne;
        }

        public Person()
        {

        }

    }
}
