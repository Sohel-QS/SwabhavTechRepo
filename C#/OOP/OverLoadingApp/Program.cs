using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(100);
            PrintDetails(100.56f);
            PrintDetails("Hello");
            PrintDetails('#');
            PrintDetails(100.55);
            PrintDetails(true);
        }
        static void PrintDetails(int num)
        {
            Console.WriteLine("Overload #1 Integer : {0}", num);
        }
        private static void PrintDetails(float num)
        {
            Console.WriteLine("Overload #2 Float : {0}", num);
        }
        private static void PrintDetails(double num)
        {
            Console.WriteLine("Overload #5 Double : {0}", num);
        }
        private static void PrintDetails(string name)
        {
            Console.WriteLine("Overload #3 Integer : {0}", name);
        }
        private static void PrintDetails(bool num)
        {
            Console.WriteLine("Overload #6 Integer : {0}", num);
        }
        private static void PrintDetails(char character)
        {
            Console.WriteLine("Overload #4 Integer : {0}", character);
        }
    }
}
