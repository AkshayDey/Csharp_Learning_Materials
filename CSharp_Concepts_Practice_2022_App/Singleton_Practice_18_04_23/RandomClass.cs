using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Practice_18_04_23
{
    public class RandomClass
    {
        private static RandomClass instance;

        private RandomClass()
        {
        }

        public static RandomClass CreateInstance()
        {
            if(instance == null) 
            {
                instance = new RandomClass();
            }
            return instance;
        }

        public void DoSomeWork()
        {

        }
    }
}
