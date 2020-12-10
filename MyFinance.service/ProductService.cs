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
    public class ProductService : Service<Product>, IProductService
    {
       static IDatabaseFactory factory = new DatabaseFactory();
        static IUnitOfWork iow = new UnitOfWork(factory);
        public ProductService(): base(iow)
        {
                
        }

        public IEnumerable<Product> getListByPrix()
        {
            //List<Product> getList;
            //getList = iow.getRepository<Product>().GetAll().OrderByDescending(x => x.Price).ToList();
            return GetAll().OrderByDescending(x => x.Price);
        }

        public IEnumerable<Product> getListByCategory(String cat)
        {

            return GetAll().Where(p => p.Category.Name.Equals(cat));
        }

        public IEnumerable<Product> getListByQte()
        {

            return GetAll().OrderByDescending(p => p.Quantity).Take(2);
        }
        public int nb_Product_Prov(Provider p, int top)
        {
            //return GetAll().Where(x => x.Providers.Equals(p) && x.Quantity > top).Count();
            return p.Products.Where(x => x.Quantity >= top).Count();
        }
    }
}
