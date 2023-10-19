﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAgainPracticeExample
{
    public class BubbleSort
    {
        private List<int> _items;
        public BubbleSort(List<int> items)
        {
            _items = items;
        }

        public delegate int Compare(int x, int y);
        public void Sort(Compare aCompare)
        {
            int temp;
            for (int j = 0; j <= _items.Count - 2; j++)
            {
                for (int i = 0; i <= _items.Count - 2; i++)
                {
                    if (aCompare(_items[i], _items[i+1]) > 0)
                    {
                        temp = _items[i + 1];
                        _items[i + 1] = _items[i];
                        _items[i] = temp;
                    }
                }
            }
        }
    }
}
