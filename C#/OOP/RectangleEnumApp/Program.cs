using System;

namespace RectangleEnumApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Height = 20;
            rect.Width = 10;
            rect.BorderColor = ColorType.GREEN;

            PrintDetails(rect);
        }

        private static void PrintDetails(Rectangle rectangle)
        {
            Console.WriteLine("Width :{0}\nHeight :{1}\nBorder Color :{2}\nArea :{3}\n", rectangle.Width, rectangle.Height, rectangle.BorderColor, rectangle.Area);
        }

        public void Display()
        {
            Console.WriteLine("Rectangle Created");
        }
    }
}
