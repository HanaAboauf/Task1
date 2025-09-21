using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03.Models;

namespace EF_01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public decimal Hour_Rate { get; set; }
        public Department? Department { get; set; }

        public int DepartmentId { get; set; }

        public Department containedByCourse { get; set; } = null!;

        public ICollection<InstructorCourses> courses= new HashSet<InstructorCourses>();


    }
}
