using System;
using CustomLinkedListApp.Model;

namespace CustomLinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();

            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);
            linkedList.Add(40);
            linkedList.Add(50);
            linkedList.Add(60);
            linkedList.Add(70);

            linkedList.Display();
            Console.WriteLine("Total items in Linked List :{0}\n",linkedList.Count);

            var linkedItem = linkedList.Remove(40);

            linkedList.Display();
            Console.WriteLine("Total items in Linked List :{0}\n", linkedList.Count);
            Console.WriteLine("Removed item from Linked List :{0}\n", linkedItem.Data);
        }
    }
}
