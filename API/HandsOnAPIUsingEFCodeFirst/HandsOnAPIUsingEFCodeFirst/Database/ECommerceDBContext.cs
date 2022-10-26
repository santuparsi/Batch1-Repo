using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnAPIUsingEFCodeFirst.Entities;
namespace HandsOnAPIUsingEFCodeFirst.Database
{
    public class ECommerceDBContext:DbContext
    {
        //Entity set
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ECommerceDB1026;User ID=sa;Password=pass@word1");
        }
    }
}
