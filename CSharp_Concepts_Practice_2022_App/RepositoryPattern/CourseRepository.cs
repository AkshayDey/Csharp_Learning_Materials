using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class CourseRepository
    {
        public void Add(Course course)
        {

        }

        public void Find(Course course) 
        { 
        
        }

        public Course Get(int id) 
        { 
          throw new NotImplementedException();
        }

        public void Remove(Course course)
        {
            throw new NotImplementedException();
        }

        public Course this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); } 
        }
    }
}
