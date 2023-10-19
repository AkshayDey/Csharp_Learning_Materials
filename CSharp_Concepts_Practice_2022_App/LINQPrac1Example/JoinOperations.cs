using LINQPrac1Example.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class JoinOperations
    {
        public List<Product> GetProductList()
        {

            return Products.ProductList;

        }


        public int CrossJoinQuery()
        {
            List<Product> products = GetProductList();
            string[] category =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"

            };

            var result = (from c in category
                         join p in products on c equals p.Category
                         select (Category: c, ProductName: p.ProductName)).Take(10);

            foreach (var allResults in result) 
            { 
                Console.WriteLine($"Category: {allResults.Category}, ProductName : {allResults.ProductName}");
            
            }


            return 0;
        }

        public int GroupJoinQquery()
        {
            #region group-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = from c in categories
                    join p in products on c equals p.Category into ps
                    select (Category: c, Products: ps);

            foreach (var v in q)
            {
                Console.WriteLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    Console.WriteLine("   " + p.ProductName);
                }
            }
            #endregion
            return 0;
        }

        public int CrossGroupJoin()
        {
            #region cross-group-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = from c in categories
                    join p in products on c equals p.Category into ps
                    from p in ps
                    select (Category: c, p.ProductName);

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
            #endregion
            return 0;
        }
    }
}
