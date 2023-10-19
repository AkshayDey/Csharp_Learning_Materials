using LINQPrac1Example.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class ElementOperations
    {
        public List<Product> GetAllProducts()
        {
            return Products.ProductList;
        }


        public int FirstElement()
        {
            List<Product> products = GetAllProducts();
            

            var resultedProducts = (from p in products
                                   where p.Category == "Seafood"
                                    select p).FirstOrDefault();

            Console.WriteLine(resultedProducts.ProductName);
            return 0;
        }
        public int FindFirstMatching()
        {
            string[] items = { "Zero", "One", "Over", "Two", "Onsite" };

            
            var resultedItems = items.First(s => s[0] == 'Z');

            Console.WriteLine(resultedItems);
            return 0;
        }
    }
}
