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
    /// Конфигурация для модели класса Subject
    /// </summary>
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        /// <summary>
        /// Конфигурирует модель
        /// </summary>
        /// <param name="builder">Строитель для конфигурации</param>
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasMany(s => s.StudentCards).WithMany(sc => sc.Subjects);
            builder.HasMany(s => s.Marks).WithOne(m => m.Subject).HasForeignKey(m => m.SubjectId);
            builder.Property(s => s.Name).HasMaxLength(30);
        }
    }
}