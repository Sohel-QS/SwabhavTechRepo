using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int math = 0;
            int math2 = 5;
            Console.WriteLine(math.GetHashCode());
            math += math2;
            int* pt = &math; 
        }
    }
}
