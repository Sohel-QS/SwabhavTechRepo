using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp.Model
{
    interface IQueue<T> : IEnumerable<T>
    {
        void Enque(T item);
        T Deque();
        int Count();
    }
}
