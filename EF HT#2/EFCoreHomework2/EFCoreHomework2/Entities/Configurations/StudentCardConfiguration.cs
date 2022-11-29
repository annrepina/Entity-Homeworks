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
    /// Конфигурация для модели класса StudentCard
    /// </summary>
    public class StudentCardConfiguration : IEntityTypeConfiguration<StudentCard>
    {
        /// <summary>
        /// Конфигурирует модель
        /// </summary>
        /// <param name="builder">Строитель для конфигурации</param>
        public void Configure(EntityTypeBuilder<StudentCard> builder)
        {
            builder.HasKey(sc => sc.Id);
            builder.Property(sc => sc.SerialNumber).IsRequired();
            builder.HasOne(sc => sc.Student).WithOne(s => s.StudentCard).HasForeignKey<Student>(s => s.StudentCardId);
            builder.HasAlternateKey(sc => sc.SerialNumber);
            builder.HasMany(sc => sc.Subjects).WithMany(s => s.StudentCards);
            builder.HasMany(sc => sc.Marks).WithOne(m => m.StudentCard).HasForeignKey(m => m.StudentCardId);
        }
    }
}