using MyFinance.data;
using MyFinance.domain.Entities;
using MyFinance.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.console
{
    class Program
    { 
        static void Main(string[] args)
        {
             //Category c = new Category() { Name = "sport" };
            //Category c2 = new Category() { Name = "cosmetique" };
            Product p = new Product() { Name = "XXXX" };
            //MyFinanceContext ctx = new MyFinanceContext();
           //ctx.Categories.Add(c);
            //ctx.Categories.Add(c2);
           // ctx.Products.Add(p);
           // ctx.SaveChanges();
            
            IProductService ips = new ProductService();
            ips.Add(p);
            ips.Commit();
            foreach (var x in ips.getListByPrix())
            {
                Console.WriteLine(x.Name.ToString());
            }
            System.Console.WriteLine("exit");
            Console.ReadKey();



        
        }

    }
}
