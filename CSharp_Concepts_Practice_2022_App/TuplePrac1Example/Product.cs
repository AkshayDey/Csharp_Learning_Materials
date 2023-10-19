using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplePrac1Example
{
    public class Product
    {
        //private int varOne = 12;
        //public (int Sum, int Multiply) DoCalculation (int x, int y)
        //{
        //    return (x + y, x * y );
        //}

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
        
    }

    public static class Products
    {
        public static List<Product> productList = new List<Product>()
        {
            new Product { ProductCode = "P1234", ProductName = "Coffe",  Category = "Beverages", UnitsInStock = 10},
            new Product { ProductCode = "P1235", ProductName = "Banana", Category = "Fruits",    UnitsInStock = 20},
            new Product { ProductCode = "P1236", ProductName = "Chai",   Category = "Beverages", UnitsInStock = 30},
            new Product { ProductCode = "P1234", ProductName = "Coffe",  Category = "Beverages", UnitsInStock = 40},
            new Product { ProductCode = "P1234", ProductName = "Coffe",  Category = "Beverages", UnitsInStock = 5}
        };
    }


}
