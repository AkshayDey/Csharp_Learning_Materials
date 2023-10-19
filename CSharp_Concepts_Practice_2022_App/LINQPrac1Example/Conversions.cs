using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class Conversions
    {


        public int ConvertToArray()
        {

            double[] doubleNumbers = new double[] { 1.9, 3.5, 4.5, 8.9, 10, 11.3, 11.4, 11.2 };

            var doubleItems = from d in doubleNumbers
                              orderby d descending
                              select d;

            double[] result = doubleItems.ToArray();

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            return 0;
        }

        public int CovertToDictionary()
        {
            var items = new[]
            {
                new {Name = "Alice", Age = 12},
                new {Name = "Bob", Age = 23},
                new {Name = "Cathy", Age = 45}
            };

            var itemsDictionary = items.ToDictionary(p => p.Name);

            foreach(var allItems in itemsDictionary)
            {
                Console.WriteLine($"{allItems.Key}'s age is {allItems.Value.Age} ");
            }
            //Console.WriteLine($"Bob's age is : { itemsDictionary["Bob"].Age}");
            return 0;
        }

        public int ConvertSelectedItems()
        {
            object[] items = new object[] { null, 1.5, 5, 2.1, 2.2, 3.3}; 
            
            int allItems = items.Count();

            var doubleItems = items.OfType<double>();

            foreach( var alldoubleItems in doubleItems)
            {
                Console.WriteLine(alldoubleItems);
            }
            
            return 0;
        }

    }
}
