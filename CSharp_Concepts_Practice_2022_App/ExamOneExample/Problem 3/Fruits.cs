using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOneExample.Problem_3
{
    public class Fruits
    {

        public void GetFruitsGrouped()
        {
            string[] fruits = { "Banana", "apple", "canna", "janna" };



            var groupedFruits = from f in fruits
                                group f by f[f.Length-1] into g
                                select (LastLetter: g.Key, GroupedLetter: g);

            foreach(var allResult in groupedFruits) 
            {
                Console.WriteLine(allResult.LastLetter);
                Console.WriteLine();

                foreach (var allItemsInGLetter in allResult.GroupedLetter)
                {
                    Console.WriteLine(allItemsInGLetter);
                }
            }
        }
    }
}



