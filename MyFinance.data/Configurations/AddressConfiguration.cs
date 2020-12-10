using MyFinance.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.data.Configurations
{
    class AddressConfiguration : ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(p => p.City).IsRequired();
            Property(p => p.StreetAddress).HasMaxLength(50)
                .IsOptional();
        }
    }
}
