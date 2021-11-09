using System;

namespace InheritanceConstructor2App.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
        }

        private static void Part2()
        {
            Console.WriteLine("part 2 \n");

            Child child = new Child(200);
            Console.WriteLine(child.GetFoo);
        }

        private static void Part1()
        {
            Console.WriteLine("Part 1 \n");
            Child child = new Child();
            Console.WriteLine(child.GetFoo + "\n");

            Child child2 = new Child();
            Console.WriteLine(child2.GetFoo + "\n");
        }
    }
}
