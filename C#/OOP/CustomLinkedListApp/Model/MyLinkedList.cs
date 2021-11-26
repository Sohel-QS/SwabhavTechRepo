using System;

namespace CustomLinkedListApp.Model
{
    class MyLinkedList<T>
    {
        private static Node<T> _head = new Node<T>();
        private static int _count = 0;
        private static Node<T> _tail = new Node<T>();
        public int Count
        { 
            get => _count;
        }
        public void Add(T data)
        {
            if (_head.Data.Equals(default(T)))
            {
                _head.Data = data;
                _tail = _head;
                _count++;
            }
            else
            {
                Node<T> newNode = new Node<T>();
                _tail.NextNode = newNode;
                newNode.Data = data;
                _tail = newNode;
                _count++;
            }
        }

        public Node<T> Remove(T data)
        {
            var node = _head;
            var temp = _tail.NextNode;
            do
            {

                if (_head.Data.Equals(data))
                {
                    temp = _head;
                    _head = _head.NextNode;
                    _count -= 1;
                    break;
                }
                else if (node.NextNode.Data.Equals(data))
                {
                    if(node.NextNode.NextNode == null)
                    {
                        temp = node.NextNode;
                        node.NextNode = null;
                        _count -= 1;
                        break;
                    }
                    else
                    {
                        temp = node.NextNode;
                        node.NextNode = node.NextNode.NextNode;
                        _count -= 1;
                        break;
                    }
                }
                node = node.NextNode;
            } while (node != null);
            
            return temp;
        }

        public void Display()
        {
            var node = _head;
            Console.WriteLine("Linked List Data :");
            do
            {
                Console.WriteLine(node.Data);
                node = node.NextNode;
            } while (node != null);
            Console.Write("\n");
        }
    }
}
