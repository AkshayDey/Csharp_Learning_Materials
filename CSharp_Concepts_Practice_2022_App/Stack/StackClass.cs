using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackClass<T>
    {
        public List<T> listOfItems { get; set; }

        public StackClass()
        {
            listOfItems = new List<T>();
        }

        public void Add(T item)
        {
            listOfItems.Add(item);
            //Stack<int> stackOne = new Stack<int>();
            //Queue<int> queue = new Queue<int>();
        }

        public int Count()
        {
            return listOfItems.Count;
        }

        public T pop()
        {
            if (Count() == 0)  // Here the count is listItems list 
            {
                throw new InvalidOperationException("List item is empty");
            }

            int IndexItem = Count() - 1;
            T popItem = listOfItems[IndexItem];
            listOfItems.RemoveAt(IndexItem);
            return popItem;

        }
        public T Peek()
        {
            if(listOfItems.Count == 0)
            {
                throw new InvalidOperationException("List item is empty");
            }
            
            T peekItem = listOfItems[0];
            return peekItem;
        }

        

    }
}
