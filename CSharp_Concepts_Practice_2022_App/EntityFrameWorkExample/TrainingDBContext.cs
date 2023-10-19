using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class TrainingDBContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDBContext() 
        { 
          _connectionString = "Server=.\\SQLEXPRESS;Database=Practice_DB_01;User Id=sa;Password=sa123456$;Trust Server Certificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public DbSet<Course> Courses { get; set; }
    }
}
