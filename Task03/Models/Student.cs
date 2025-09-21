using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03.Models;

namespace EF_01.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }

        public Department? Department { get; set; }

      public  StudentCourses? StudentCourse { get; set; }

    }
}
