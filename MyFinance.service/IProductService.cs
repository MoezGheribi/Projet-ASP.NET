using MyFinance.domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.service
{
    public interface IProductService :IService<Product>
    {
         IEnumerable<Product> getListByPrix();

        IEnumerable<Product> getListByCategory(String cat);

        IEnumerable<Product> getListByQte();
         int nb_Product_Prov(Provider p, int top);

    }

    



}
