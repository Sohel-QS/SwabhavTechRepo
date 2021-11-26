using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPatternApp.Model;

namespace ProxyPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Part1
            IImage image1 = new RealImage("One.jpg");
            IImage image2 = new RealImage("Two.jpg");
            IImage image3 = new RealImage("Three.jpg");

            image3.Display();

            Console.WriteLine("\n\n");

            IImage image4 = new ProxyImage("For.jpg");
            IImage image5 = new ProxyImage("Five.jpg");
            IImage image6 = new ProxyImage("Six.jpg");

            image6.Display();
            Console.ReadKey();
        }
    }
}
