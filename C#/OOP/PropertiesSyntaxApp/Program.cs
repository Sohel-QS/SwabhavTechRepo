using System;

namespace PropertiesSyntaxApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo obj = new Foo();
            Console.WriteLine(obj.Bar);
            obj.Bar = 200;
            Console.WriteLine(obj.Bar);

            Console.WriteLine(obj.Baz);

            Foo obj2 = new Foo();
            Console.WriteLine(obj2.Baz);

            Foo obj3 = new Foo();
            Console.WriteLine(obj3.Baz);
        }
    }
}
