using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }

        public DateTime ClassStartDate { get; set; }

    }
}
