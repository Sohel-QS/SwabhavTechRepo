using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericNodeApp.Model;

namespace GenericNodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> n1 = new Node<string>();
            n1.Data = "Mumbai";

            Node<string> n2 = new Node<string>();
            n2.Data = "Pune";

            Node<string> n3 = new Node<string>();
            n3.Data = "Nashik";

            n1.NextNode = n2;
            n2.NextNode = n3;

            PrintDetails(n1);
            PrintDetails(n2);
        }

        private static void PrintDetails(Node<string> n)
        {
            var node = n;
            Console.WriteLine("Data :");
            do
            {
                Console.WriteLine(node.Data);
                node = node.NextNode;
            }while (node != null);
            Console.Write("\n");
        }
    }
}
