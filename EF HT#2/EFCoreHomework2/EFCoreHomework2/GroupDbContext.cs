using EFCoreHomework2.Entities;
using EFCoreHomework2.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2
{
    /// <summary>
    /// Представляет сеанс с базой данный и предоставляет API для взаимодействия с базой данных
    /// </summary>
    public class GroupDbContext : DbContext
    {
        /// <summary>
        /// Коллекция для сущности Student, которая будет являться таблицей в базе данных
        /// </summary>
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// Коллекция для сущности StudentCards, которая будет являться таблицей в базе данных
        /// </summary>
        public DbSet<StudentCard> StudentCards { get; set; }

        /// <summary>
        /// Коллекция для сущности Subjects, которая будет являться таблицей в базе данных
        /// </summary>
        public DbSet<Subject> Subjects { get; set; }

        /// <summary>
        /// Коллекция для сущности Marks, которая будет являться таблицей в базе данных
        /// </summary>
        public DbSet<Mark> Marks { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public GroupDbContext()
        {
        }

        /// <summary>
        /// Метод, который вызывается при созданиие экземпляра DbContext
        /// Задает конфигурацию для контекста базы данных
        /// </summary>
        /// <param name="optionsBuilder"></param>
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
        /// Метод который конфигурирует модели базы данных
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCardConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new MarkConfiguration());  
        }
    }
}