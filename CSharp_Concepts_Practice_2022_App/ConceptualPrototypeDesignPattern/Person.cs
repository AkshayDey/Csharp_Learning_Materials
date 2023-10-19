using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualPrototypeDesignPattern
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public IdInfo IdInfo { get; set; }


        public Person ShallowCopy()
        {
            //Person aPerson = new Person();
            //aPerson.Age = Age;
            //aPerson.Name = Name;
            //aPerson.BirthDate = BirthDate;

            return (Person) this.MemberwiseClone();

            //return aPerson;
        }

        public Person DeepCopy()
        {
            Person bPerson = (Person)this.MemberwiseClone();
            bPerson.IdInfo = new IdInfo(IdInfo.ID);
            bPerson.Name = String.Copy(Name);
            return bPerson;
        }

        public static void  DisplayValues(Person p)
        {
            Console.WriteLine(" Name: {0:s}, Age: {1:d}, Birthdate: {2: MM/dd/yy}", p.Name, p.Age, p.BirthDate);
        }

    }
}
