using MyFinance.Data.Infrastructure;
using MyFinance.domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.service
{
   public class FactureService : Service<Factures>, IFactureService
    {
        static IDatabaseFactory factory = new DatabaseFactory();
        static IUnitOfWork iow = new UnitOfWork(factory);
        public FactureService(): base(iow)
        {

        }
        public int NB_Produit(Client c)
        {
            IEnumerable<Factures> fact = GetAll().Where(x => x.Client.Equals(c) && x.DateAchat.Equals(DateTime.Now));
            return fact.Select(x => x.Product).Count();
        }

    }
}
