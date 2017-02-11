using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Stack<T>
    {
        private List<T> _list = new List<T>();

        public bool HasItems
        {
            get
            {
                return _list.Count > 0;
            }
        }


        public void Clear()
        {
            _list.Clear();
        }

        public void Push(T obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add a null value to the stack.");

            _list.Add(obj);
        }

        public T Pop()
        {
            //If list is empty, throw exception
            if (_list.Count == 0)
                throw new InvalidOperationException("Cannot pop items from an empty stack.");

            //Get the position of the last item inserted
            int topItemIndex = _list.Count - 1;

            //Get the item
            T topItem = _list[topItemIndex];

            //Remove it from the list
            _list.RemoveAt(topItemIndex);

            //Return the item
            return topItem;
        }
    }
}
