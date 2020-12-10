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
    public class ProviderService : Service<Provider> ,IProviderService
    {
        static IDatabaseFactory factory = new DatabaseFactory();
        static IUnitOfWork iow = new UnitOfWork(factory);
        public ProviderService(): base(iow)
        {

        }
    }
}
