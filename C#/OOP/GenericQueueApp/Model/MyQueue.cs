using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp.Model
{
    class MyQueue<T> : IQueue<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();
        public int Count()
        {
            return _items.Count();
        }

        public T Deque()
        {
            var temp = _items.First.Value;
            _items.RemoveFirst();
            return temp;
        }

        public void Enque(T item)
        {
            _items.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
