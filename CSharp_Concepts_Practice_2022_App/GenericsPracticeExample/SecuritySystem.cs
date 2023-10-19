using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeExample
{
    public class SecuritySystem <T> where T : IUser
    {
        public T UserName  { get; set; }

        public void  showFullName()
        {
            Console.WriteLine(UserName);
        }
    }
}
