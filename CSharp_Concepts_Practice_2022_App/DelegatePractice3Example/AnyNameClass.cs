using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice3Example
{
    public  class AnyNameClass<T>
    {
        public List<T> _items;

        public AnyNameClass(List<T> items) 
        { 
            _items= items;
        }
        public delegate int Compare (T a, T b);
        public void SortNumbers (Compare compare)
        {
            T temp;
            for (int j = 0; j <= _items.Count - 2; j++)
            {
                for (int i = 0; i <= _items.Count - 2; i++)
                {
                    if (compare(_items[i], _items[i+1]) > 0)
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
