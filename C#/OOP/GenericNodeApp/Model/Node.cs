using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp.Model
{
    class Node<T>
    {
        private T _data;
        private Node<T> _nextNode=null;

        public T Data 
        { 
            get => _data; 
            set => _data = value;
        }
        public Node<T> NextNode 
        { 
            get => _nextNode; 
            set => _nextNode = value; 
        }
    }
}
