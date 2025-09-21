using EF_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.DatabaseContexts
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-TN70H9CL; Database= ITITask; Trusted_Connection= true; TrustServerCertificate=True");
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Instructor> instructors { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Course> Courses { get; set; }






    }
}
