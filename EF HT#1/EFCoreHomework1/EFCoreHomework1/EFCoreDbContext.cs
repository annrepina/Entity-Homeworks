using EFCoreHomework1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework1
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class EFCoreDbContext : DbContext
    {
        /// <summary>
        /// Заказы
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public EFCoreDbContext()
        {
        }

        /// <summary>
        /// Перегрузка метода OnConfiguring, который настраивает базу данных для текущего контекста
        /// </summary>
        /// <param name="optionsBuilder">Билдер, который создает или изменяет параметры для этого контекста</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());

            // получаем конфигурацию из файла appSettings.json
            builder.AddJsonFile("appSettings.json");

            // создаем конфигурацию
            var config = builder.Build();

            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        /// <summary>
        /// Метод, который настраивает модель
        /// </summary>
        /// <param name="modelBuilder">Билдер, который конструирует модель для контекста</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                    new Order { Id = 1, Sum = 100 },
                    new Order { Id = 2, Sum = 200 },
                    new Order { Id = 3, Sum = 300 },
                    new Order { Id = 4, Sum = 400 },
                    new Order { Id = 5, Sum = 500 }
                    );
        }
    }
}
