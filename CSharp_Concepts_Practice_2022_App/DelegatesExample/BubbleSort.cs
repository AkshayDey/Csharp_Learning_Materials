using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class BubbleSort<T>
    {

        private List<T> _items;
        public delegate int Compare(T x, T y);


        public BubbleSort(List<T> items) => _items = items;
        

        public void Sort(Compare aCompare)
        {
            T temp;
            for (int j = 0; j <= _items.Count - 2; j++)
            {
                for (int i = 0; i <= _items.Count - 2; i++)
                {
                    if (aCompare(_items[i], _items[i + 1]) > 0 )
                    {
                        temp = _items[i + 1];
                        _items[i + 1] = _items[i];
                        _items[i] = temp;
                    }
                }
            }
        }

       

        //public delegate int DoSum(int a, int b);
        //public delegate void DoSubtract(int p, int q);

        //public int  Sum(int a , int b)
        //{
        //    //Console.WriteLine(a+b);

        //    return a + b;
        //}
        //public void Subtract(int p, int q)
        //{
        //    if (p > q)
        //    {
        //        Console.WriteLine(p - q);
        //    }
        //    else
        //    {
        //        Console.WriteLine(q - p);
        //    }
        //}


    }
}
