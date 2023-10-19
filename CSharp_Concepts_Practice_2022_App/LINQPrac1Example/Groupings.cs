using LINQPrac1Example.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class Groupings
    {

        public List<Product> GetProductList()
        {
            return Products.ProductList;
        }

        public int GroupingSyntax()
        {
            int[] numbers = { 4, 5,  1, 3, 9, 8, 6, 7, 2, 0 };

            var dividendNumbers = from n in numbers
                                  group n by n % 2 == 0 into g
                                  select (Rem: g.Key, Num: g);

            foreach (var numbersInCollection in dividendNumbers)
            {
                Console.WriteLine($"Numbers with a remainder of {numbersInCollection.Rem} when divided by 2");
                foreach (var n in numbersInCollection.Num)
                {
                    Console.WriteLine(n);
                }
            }

            return 0;
        }

        public int GroupByCategory()
        {
            string[] fruits = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var categorizedFruits = from f in fruits
                                    group f by f[0] into g
                                    select (fruitsCat: g.Key, fruits: g);


            foreach (var allItems in categorizedFruits)
            {
                Console.WriteLine($"Fruits Category : {allItems.fruitsCat}");
                foreach (var items in allItems.fruits)
                {
                    Console.WriteLine($"Fruits Name : {items}" );
                }


            }
            return 0;
        }

        public int GroupByCategoryProducts()
        {
            #region groupby-category
            List<Product> products = GetProductList();

            var orderGroups = from p in products
                              group p by p.Category into g
                              select (Category: g.Key, Products: g);

            foreach (var orderGroup in orderGroups)
            {
                Console.WriteLine($"Products in {orderGroup.Category} category:");
                foreach (var product in orderGroup.Products)
                {
                    Console.WriteLine($"\t{product}");
                }
            }
            #endregion
            return 0;
        }

        public void GroupByCategorySumOfUnitPrice()
        {
            List<Product> products = GetProductList();

            var orderGroups = from p in products
                              group p by p.Category into g
                              select (Category: g.Key, SumOfUnitPrice: g.Sum(s => s.UnitPrice));

            foreach (var allItemsInOrderGroups in orderGroups)
            {
                Console.WriteLine($"Category : {allItemsInOrderGroups.Category}  and Sum of Unit Price : {allItemsInOrderGroups.SumOfUnitPrice}");
            }
        }

    }
}
