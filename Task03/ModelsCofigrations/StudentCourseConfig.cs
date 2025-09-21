using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03.Models;

namespace Task03.ModelsCofigrations
{
    internal class StudentCourseConfig : IEntityTypeConfiguration<StudentCourses>
    {
        public void Configure(EntityTypeBuilder<StudentCourses> builder)
        {
            builder.HasMany(sc => sc.Students)
                  .WithOne(s => s.StudentCourse);

            builder.HasMany(sc => sc.Courses)
                   .WithOne(c => c.Student);
                 
        }
    }
}
