using System;

namespace InheritanceConstructor2App.Model
{
    class Child : Parent
    {
        public Child():base(100)
        {
            Console.WriteLine("Child is Created");
        }
        public Child(int foo) : base(foo)
        {
            Console.WriteLine("Parameterized Child is Created");
        }
    }
}
