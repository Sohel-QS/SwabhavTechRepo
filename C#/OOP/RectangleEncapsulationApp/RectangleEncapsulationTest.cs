using System;

namespace RectangleEncapsulationApp.Model
{
    class RectangleEncapsulationTest
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.SetWidth(-10);
            rect.SetHeight(40);

            Console.WriteLine("Width :{0}", rect.GetWidth());
            Console.WriteLine("Height :{0}", rect.GetHeight());
        }
    }
}
