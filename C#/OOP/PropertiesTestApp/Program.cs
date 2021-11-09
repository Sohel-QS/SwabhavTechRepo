using System;

namespace PropertiesTestApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleProp prop = new RectangleProp(150, 100, "red", "green");

            prop.SetFillColor("green");
            prop.SetBorderColor("blue");

            Console.WriteLine("Width = {0}\nHeight = {1}\nFill Color = {2}\nBorder Color = {3}", prop.GetWidth(), prop.GetHeight(), prop.GetFillColor(), prop.GetBorderColor());
        }
    }
}
