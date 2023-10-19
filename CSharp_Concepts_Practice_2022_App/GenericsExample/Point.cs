using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Point <T, V>   // Generic Parameter
    {
        public T X { get; set; }
        public V Y { get; set; }

    }

    public class Point2<T, V>  
        where T : struct
        where V : struct
    {
        public T P { get; set; }
        public V Q { get; set; }
    }

    public class SuperPoint<A, B, C> : Point<A, B>
    {
        public C Z { get; set; }
    }

    public class Person : IUser
    {
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PassWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }

}
