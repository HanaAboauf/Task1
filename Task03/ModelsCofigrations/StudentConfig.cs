using EF_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.ModelsCofigrations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(s=>s.Department)
                .WithMany(d=>d.Students)
                .HasForeignKey(s=>s.DeptId);
        }
    }
}
