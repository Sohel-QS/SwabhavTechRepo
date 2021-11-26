using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorApp.Decorator;
using HatDecoratorApp.Model;

namespace HatDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IHat hat = new StanderdHat();
            RibbonedHat ribboned = new RibbonedHat(new GoldenHat(hat));
            PrintDetails(ribboned);

            ribboned = new RibbonedHat(hat);
            PrintDetails(ribboned);

            GoldenHat golden = new GoldenHat(hat);
            PrintDetails(golden);
        }

        private static void PrintDetails(HatDecorator ribboned)
        {
            Console.WriteLine(">>>"+ribboned.GetName()+"\nPrice :"+ribboned.GetPrice()+"\n\nDescription :\n"+ribboned.GetDesciption()+"\n");
        }
    }
}
