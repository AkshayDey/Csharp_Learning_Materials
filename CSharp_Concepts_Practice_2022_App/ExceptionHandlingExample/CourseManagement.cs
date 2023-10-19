using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExample
{
    public class CourseManagement
    {
        List<string> courses = new List<string>();

        public CourseManagement()
        {
            courses.Add("PHP");
        }

        public void AddCourses(string title)
        {

            try
            {
                var count = courses.Where(x => x == title).ToList().Count();
                if (count > 0)
                {
                    throw new DuplicateException("Course name already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a  problem in checking exisiting course",  ex);
            }
            finally
            {
                Console.WriteLine("Program Ended");
            }
        }
    }
}
