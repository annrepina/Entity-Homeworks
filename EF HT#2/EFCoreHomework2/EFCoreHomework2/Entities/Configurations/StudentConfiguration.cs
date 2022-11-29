using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities.Configurations
{
    /// <summary>
    /// Конфигурация для модели класса Student
    /// </summary>
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        /// <summary>
        /// Конфигурирует модель
        /// </summary>
        /// <param name="builder">Строитель для конфигурации</param>
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Birthday).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(10);
            builder.HasAlternateKey(x => x.PhoneNumber);
        }
    }
}