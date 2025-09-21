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
    [PrimaryKey(nameof(StudentId),nameof(CourseId))]
    internal class StudentCourses
    {
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public  ICollection<Student> Students =new HashSet<Student>();

        public ICollection<Course> Courses = new HashSet<Course>();

    




    }
}
