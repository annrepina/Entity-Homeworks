using EFCoreHomework1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            optionsBuilder.UseSqlServer("Server=S-DEV-3\\TESTDB;Database=EFCoreHomework1Repina;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=True;");
        }
    }
}
