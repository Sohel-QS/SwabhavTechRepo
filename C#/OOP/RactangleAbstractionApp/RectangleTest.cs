using System;
using RactangleAbstractionApp.Model;

namespace RactangleAbstractionApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle smallRect = new Rectangle();
            smallRect.width = 10;
            smallRect.height = 6;
            Console.WriteLine("\nSmall Rectangle\nWeight :{0}\nHeight :{1}\nArea :{2}", smallRect.width, smallRect.height,smallRect.CalculateArea());

            Rectangle bigRect = new Rectangle();
            bigRect.width = 120;
            bigRect.height = 80;
            Console.WriteLine("\nBig Rectangle \nWeight :{0}\nHeight :{1}\nArea :{2}\n", bigRect.width, bigRect.height, bigRect.CalculateArea());

            Rectangle temp = smallRect;
            Console.WriteLine("Temp Object Width :{0}", temp.width);
            Console.WriteLine("Small Object Width :{0}", smallRect.width);

            temp.width = temp.width + 7;
            Console.WriteLine("Temp Object Width :{0}", temp.width);
            Console.WriteLine("Small Object Width :{0}\n", smallRect.width);

            Console.WriteLine("Hash Code for smallRect :"+smallRect.GetHashCode());
            Console.WriteLine("Hash Code for bigRect :" + bigRect.GetHashCode());
            Console.WriteLine("Hash Code for temp :" + temp.GetHashCode());
        }
    }
}
