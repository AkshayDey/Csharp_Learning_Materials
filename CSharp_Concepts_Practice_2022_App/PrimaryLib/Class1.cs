using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Example
{
    public class Class1
    {
        private IClass _class;
        //public Class3 Name { get; set; } // Here Class3 is not the dependency of Class1 because Class1 is not using Class3 here
        public Class1(IClass @class) // Dependency Injection 
        {
            _class = @class;

        }
        
        public void DoSomething()
        {
            int x = 10; 

            //Class2 aClass2 = new Class2();
            //aClass2.DoSomething(x);// Here Class 2 is the dependency of class1 because Class1 have to use Class2

            _class.Start(x); // eliminates totally class2 reference from class1
        }

        //public void DoSomethingAgain(Class3 class3)// Here class3 is also not the dependency of class1 because it is not using the class3's any component
        //{
        //    class3.Name = "Something"; // it is dependency
        //    Name = class3;// is not dependency
        //}
    }
}
