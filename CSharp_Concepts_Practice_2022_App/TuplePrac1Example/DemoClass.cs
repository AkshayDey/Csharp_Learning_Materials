using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplePrac1Example
{
    public class DemoClass
    {
        public List<Product> GetAllProducts()
        {
            return Products.productList;
        }

        

        public void GroupedCount()
        {
            List<Product> allProducts = GetAllProducts();

            var result = from p in allProducts
                         group p by p.Category into g
                         select (Category: g.Key, Count: g.Count(), TotalUnitsInStock: g.Sum(p => p.UnitsInStock));


            foreach (var allProductItems in result)
            {
                Console.Write("Product Category : {0}", allProductItems.Category);
                Console.Write(" ");
                Console.Write("Product Count : {0}", allProductItems.Count);
                Console.Write(" ");
                Console.Write("Total Units in Stock  : {0}", allProductItems.TotalUnitsInStock);
                Console.WriteLine();
            }
        }
    }
}
