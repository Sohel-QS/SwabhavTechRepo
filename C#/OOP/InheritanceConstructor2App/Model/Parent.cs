using System;

namespace InheritanceConstructor2App.Model
{
    class Parent
    {
        private int _foo;
        public Parent(int foo)
        {
            _foo = foo;
            Console.WriteLine("Parent is Created");
        }

        public int GetFoo
        {
            get
            {
                return _foo;
            }
        }
    }
}
