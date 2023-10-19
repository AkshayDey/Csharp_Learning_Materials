using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class SecuritySystem <T> where T : IUser
    {
        private T _user;

        public Tkey Open<Tkey>(Tkey key) where Tkey : class// Generic Method
        {
            Tkey anotherKey = default(Tkey);
            return anotherKey;
        }

    }
}
