using System;

namespace PolymorphismApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape();
            shapes[1] = new Rectangle();
            shapes[2] = new Circle();

            PrintDetails(shapes);
        }

        private static void PrintDetails(Shape[] shapes)
        {
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Draw());
            }
        }
    }
}
