using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericQueueApp.Model;

namespace GenericQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> numbers = new MyQueue<int>();
            numbers.Enque(100);
            numbers.Enque(200);
            numbers.Enque(300);

            Console.WriteLine("Queue Count :{0}", numbers.Count());
            Console.WriteLine("Removed From First :{0}", numbers.Deque());
            Console.WriteLine("Queue Count :{0}", numbers.Count());

            PrintInForEach(numbers);
            PrintWithoutForEach(numbers);
        }
        private static void PrintWithoutForEach(IQueue<int> queueData)
        {
            Console.WriteLine("\nWithout For Each Loop Queue Data : ");
            IEnumerator<int> enumarator = queueData.GetEnumerator();
            while(enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current);
            }
        }
        private static void PrintInForEach(IQueue<int> queueData)
        {
            Console.WriteLine("\nUsing For Each Loop Queue Data : ");
            foreach (var num in queueData)
            {
                Console.WriteLine(num);
            }
        }
    }
}
