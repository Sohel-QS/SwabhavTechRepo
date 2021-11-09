using System;

namespace RectangleConstructorApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy2()
        {
            Rectangle rectangle = new Rectangle(101, 20, "green", "blue");
            Console.WriteLine("Case Study 2 With OverLoading:");
            PrintDetails(rectangle);
        }
        private static void CaseStudy1()
        {
            Rectangle rectangle = new Rectangle(101, 20, "green");
            Console.WriteLine("Case Study 1 :");
            PrintDetails(rectangle);
            PrintDetails(new Rectangle(10, 5, "blue"));
        }
        private static void PrintDetails(Rectangle rect)
        {
            Console.WriteLine("Width :{0}\nHeight :{1}\nFill Color :{2}\nBorder Color :{3}\nArea :{4}\n"
                ,rect.GetWidth(), rect.GetHeight(), rect.GetFillColor(), rect.GetBorderColor(), rect.CalculateArea());
        }
    }
}
