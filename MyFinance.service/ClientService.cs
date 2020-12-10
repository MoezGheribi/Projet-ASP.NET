using MyFinance.Data.Infrastructure;
using MyFinance.domain.Entities;
using MyFinance.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public class ClientService : Service<Client> , IClientService
    {
        static IDatabaseFactory factory = new DatabaseFactory();
        static IUnitOfWork iow = new UnitOfWork(factory);
        public ClientService(): base(iow)
        {

        }
    }
}
