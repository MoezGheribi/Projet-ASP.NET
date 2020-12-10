using MyFinance.data.Configurations;
using MyFinance.data.Custom_Conventions;
using MyFinance.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.data
{
   public class MyFinanceContext : DbContext
    {
        public MyFinanceContext():base("name=MaChaine")
        {

        }
        public DbSet <Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Chemical> Chemicals { get; set; }

        public DbSet<Biological> Biologicals { get; set; }

        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new DateTime2Convention());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new FactureConfiguration());
        }
    }
}
