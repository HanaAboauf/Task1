using EF_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.ModelsCofigrations
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(d => d.InstructorManager)
                .WithOne(i => i.Department)
                .HasForeignKey<Department>(d => d.InsId);

            builder.Property<TimeSpan>("HirDate");

            builder.HasMany(d=>d.Instructors)
                   .WithOne(i=>i.containedByCourse)
                   .HasForeignKey(i => i.DepartmentId);
        }
    }
}
