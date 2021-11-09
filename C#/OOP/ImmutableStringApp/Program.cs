using System;

namespace ImmutableStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            string str2 = " This is C# Programming Language";
            Console.WriteLine("Before Modifying Str1\n{0} {1}{2}\n", str1.GetHashCode(), str1, str2);
            str1 += str2;
            Console.WriteLine("After Modifying Str1\n{0} {1}", str1.GetHashCode(), str1);
            
        }
    }
}
