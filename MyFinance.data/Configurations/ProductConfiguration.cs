using MyFinance.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(e => e.Description).HasMaxLength(200).IsOptional();
            HasMany(p => p.Providers)
            .WithMany(v => v.Products)
            .Map(m =>
            {
                m.ToTable("Providings");    
                m.MapLeftKey("Product");
                m.MapRightKey("Provider");
            });

           
            Map<Biological>(c =>
            {
                c.Requires("IsBiological").HasValue(1);  
            });
            Map<Chemical>(c =>
            {
                c.Requires("IsBiological").HasValue(0);
            });

        
            HasOptional(p => p.Category)   
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .WillCascadeOnDelete(false);

        }
    }
}
