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
    /// Конфигурация для модели класса Mark
    /// </summary>
    public class MarkConfiguration : IEntityTypeConfiguration<Mark>
    {
        /// <summary>
        /// Конфигурирует модель
        /// </summary>
        /// <param name="builder">Строитель для конфигурации</param>
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.StudentCard).WithMany(sc => sc.Marks).HasForeignKey(m => m.StudentCardId);
            builder.HasOne(m => m.Subject).WithMany(s => s.Marks).HasForeignKey(m => m.SubjectId);
        }
    }
}