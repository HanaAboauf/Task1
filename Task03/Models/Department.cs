using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hiring_Date { get; set; }
        public int InsId { get; set; }

        public Instructor InstructorManager { get; set; }

        public ICollection<Student> Students = new HashSet<Student>();

        public ICollection<Instructor> Instructors = new HashSet<Instructor>();

    }
}
