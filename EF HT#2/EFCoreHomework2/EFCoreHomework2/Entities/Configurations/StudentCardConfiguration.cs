using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities.Configurations
{
    public class StudentCardConfiguration : IEntityTypeConfiguration<StudentCard>
    {
        public void Configure(EntityTypeBuilder<StudentCard> builder)
        {
            builder.HasKey(sc => sc.Id);
            builder.Property(sc => sc.SerialNumber).IsRequired();
            builder.HasOne(sc => sc.Student).WithOne(s => s.StudentCard).HasForeignKey<Student>(s => s.StudentCardId);
            builder.HasAlternateKey(sc => sc.SerialNumber);
        }
    }
}
