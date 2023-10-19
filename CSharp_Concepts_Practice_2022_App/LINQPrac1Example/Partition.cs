using LINQPrac1Example.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class Partition
    {
        public List<Product> GetAllProducts()
        {
            return Products.ProductList;
        }

        public List<Customer> GetAllCustomer() 
        { 
           return Customers.CustomerList;
        
        }

        public void TakeSyntax()
        {
            int[] numbers = { 1, 2, 3, 4, 6, 8 };

            var takeThreeNumbers = numbers.Take(3);

            foreach (var allItems in takeThreeNumbers)
            {
                Console.WriteLine(allItems);
            }
        }

        public int NestedTake()
        {
            List<Customer> customerList = GetAllCustomer();

            var first3WAOrders = (from cust in customerList
                                 from order in cust.Orders
                                 where cust.Region == "WA"
                                 select (cust.CustomerID, order.OrderID, order.OrderDate)).Take(3);


            foreach (var allOrder in first3WAOrders)
            {
                Console.WriteLine(allOrder);
            }
            return 0;
        }
    }
}
