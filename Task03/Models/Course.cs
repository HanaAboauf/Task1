using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03.Models;

namespace EF_01.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int topId { get; set; }

        public Topic? Topic { get; set; }

        public StudentCourses? Student { get; set; }

        public ICollection<InstructorCourses> Instructors = new HashSet<InstructorCourses>();
    }
}
