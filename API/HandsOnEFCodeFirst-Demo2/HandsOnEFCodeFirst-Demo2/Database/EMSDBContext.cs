using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnEFCodeFirst_Demo2.Entities;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst_Demo2.Database
{
    public class EMSDBContext:DbContext
    {
        //Entity set
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=EMSDB4;User ID=sa;Password=pass@word1");
        }
    }
}
