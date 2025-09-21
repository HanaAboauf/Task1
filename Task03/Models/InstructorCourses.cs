using EF_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.Models
{
    [PrimaryKey(nameof(InstructorId), nameof(CourseId))]
    internal class InstructorCourses
    {
        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }

        public int Evaluation { get; set; }
    }
}
