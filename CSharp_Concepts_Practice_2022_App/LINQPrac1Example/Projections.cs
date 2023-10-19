using LINQPrac1Example.DataSources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac1Example
{
    public class Projections
    {
        public List<Product> GetProductList()
        {
            return Products.ProductList;
        }
        public List<Customer> GetCustomerList() 
        { 
           return Customers.CustomerList;
        }

        public int SelectIndex()
        {
            #region selectIndex
            int[] numbers = { 10, 11, 12, 13, 15, 16, 17, 18, 19, 20 };

            var numbersSelection = from n in numbers
                                   select n + 1;

            foreach (var n in numbersSelection) 
            {
                Console.WriteLine(n);
            
            }

            #endregion

            return 0;
        }

        public int SelectProperty()
        {
            #region select-property
            List<Product> products = GetProductList();

            var productNames = from p in products
                               select p.ProductName;

            Console.WriteLine("Product Names:");
            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }
            #endregion
            return 0;
        }

        public int TransformWithSelect()
        {
            #region select-transform
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = from n in numbers
                           select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }
            #endregion
            return 0;
        }

        public int SelectByCaseAnonymous()
        {
            #region select-case-anonymous
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            
            var upperLowerWordsAgain = from w in words
                                       select (Upper: w.ToUpper(), Lower: w.ToLower());

            foreach (var ul in upperLowerWordsAgain)
            {
                Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}");
            }
            #endregion
            return 0;
        }

       public int SelectAnonymousConstructions()
        {

            int[] numbers = { 5, 4, 3, 2, 1, 0 };
            string[] stringsOfNumbers = { "zero", "one", "two", "three", "four", "five" };

            var numbersResult = from n in numbers
                                select (Digit: stringsOfNumbers[n], Even: (n % 2 == 0));

            foreach (var allNumbersResult in numbersResult)
            {
                Console.WriteLine($"Digit {allNumbersResult.Digit} is {((allNumbersResult.Even)? "even" : "odd" )}");
            }

            return 0;
        }


        public int SelectWithWhere()
        {
            #region select-with-where
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNums = from n in numbers
                          where n < 5
                          select digits[n];

            Console.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
            #endregion
            return 0;
        }

        public int SelectFromMultipleSequences()
        {
            #region select-many-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select (a, b);

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b} and the pair is {pair}");
            }
            #endregion
            return 0;
        }

    }
}
