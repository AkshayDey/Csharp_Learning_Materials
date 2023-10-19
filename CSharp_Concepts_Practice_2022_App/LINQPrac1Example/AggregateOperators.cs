using LINQPrac1Example.DataSources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class AggregateOperators
    {

        public List<Product> GetProductList() => Products.ProductList;

        public List<Product> GetProductListCategory()
        {
            var categoryName = "Beverages";
            return Products.ProductList.Where(p => p.Category == categoryName).ToList();
        }

        public int CountSyntax()
        {
            #region count-syntax
            int[] factorsOf100 = { 1,2,2,5,5 };

            var uniqueFactors = factorsOf100.Distinct().Count();

            Console.WriteLine(uniqueFactors);

            #endregion
            return 0;
        }

        public int CountConditional()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            

            var numbersEvenOrOdd = from n in numbers
                                   group n by n % 2 == 0 into g
                                   select (CheckNumberisEvenOrOdd: g.Key, numbers: g);

            foreach (var allItems in numbersEvenOrOdd)
            {
                if(allItems.CheckNumberisEvenOrOdd == true)
                {
                    foreach (var evenItems in allItems.numbers)
                    {
                        Console.WriteLine(evenItems);
                    }
                }
            }
                                   

            return 0;
        }

        //public int GroupedCount()
        //{
        //    #region grouped-count
            
        //    List<Product> products = GetProductList();

        //    var CategoryCounts = from p in products
        //                         group p by p.Category into g

        //    #endregion
        //    return 0;
        //}

        public int MinGrouped()
        {
           

            return 0;
        }

        public int MinEachGrouped()
        {
            List<Product> products = GetProductList();

            var results = from p in products
                          group p by p.Category into g
                          let minPrice = g.Min(s => s.UnitPrice)
                          select (Category: g.Key, MaxUnitPrice: g.Where(p => p.UnitPrice == minPrice));
            

            foreach (var allItems in results)
            {
                Console.WriteLine($"Category : {allItems.Category}");
                foreach(var itemsResult in allItems.MaxUnitPrice)
                {
                    Console.WriteLine(itemsResult.UnitPrice);
                }
            }
            
            
            return 0;
        }

        public int MaxEachGrouped()
        {
            List<Product> CategoryBeverages = GetProductListCategory();

            var maximumUnitPriceInCatBeverages = CategoryBeverages.Max(p => p.UnitPrice);
            var minimumUnitPriceInCatBeverages = CategoryBeverages.Min(p => p.UnitPrice);
            
            List<Product> products = GetProductList();
            var maxEachGrouped = from a in products
                                 group a by (a.Category) into g
                                 let maxPrice = g.Max(s => s.UnitPrice)
                                 select (Category: g.Key, MaxUnitPrice: g.Where(a => a.UnitPrice == maxPrice));


            foreach (var allItems in maxEachGrouped)
            {
                Console.WriteLine(allItems.Category);

                foreach (var maxUnitPrice in allItems.MaxUnitPrice)
                {
                    Console.WriteLine(maxUnitPrice.UnitPrice);
                }
            }
                                 

            return 0;
        }

        public int MaxGroup()
        {
            List<Product> Products = GetProductList();

            var productsResult = from p in Products
                                 group p by (p.Category) into g
                                 select (CategoryName: g.Key, MostExpensivePrice: g.Max(p => p.UnitPrice));

            foreach (var allProductResult in productsResult)
            {
                Console.WriteLine($"Category Name is : {allProductResult.CategoryName} and MostExpensive Unit Price is {allProductResult.MostExpensivePrice}");
            }
            return 0;
        }

        public int MinProjection()
        {
            string[] words = { "cherry", "mango", "bannana" };

            var totalWordLength = words.Length;

            Console.WriteLine (totalWordLength);

            int shortestWord = words.Min( w => w.Length );

            Console.WriteLine($"The Shortest word is {shortestWord} characters long");

             
            return 0;
        }

        public int AggregateSyntax()
        {
            #region aggregate-syntax
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double product = doubles.Aggregate((runningProduct, nextFactor) =>runningProduct * nextFactor);

           

            Console.WriteLine($"Total product of all numbers: {product}");
            #endregion
            return 0;
        }

        
    }
}
