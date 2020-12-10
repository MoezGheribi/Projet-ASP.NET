using MyFinance.domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.data.Configurations
{
    public class FactureConfiguration : EntityTypeConfiguration<Factures>
    {
        public FactureConfiguration()
        {
            HasKey(c => new
            {
                c.ClientFk,
                c.ProductFK,
                c.DateAchat
            });
        }
    }
}
