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
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        //private string _connectionString;

        public EFCoreDbContext(/*string connectionString*/)
        {
            //_connectionString = connectionString;
        }

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
