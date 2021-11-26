using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceDecoratorApp.Decorator;
using CarServiceDecoratorApp.Model;

namespace CarServiceDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService service = new CarInspection();
            TyreRotation rotation = new TyreRotation(service);
            OilChange oilChange = new OilChange(rotation);

            PrintDetails(oilChange);

            oilChange = new OilChange(service);

            PrintDetails(oilChange);
        }

        private static void PrintDetails(CarServicing carService)
        {
            Console.WriteLine(">>>Total Servicing Cost :" + carService.GetCost()+
                "\n\nCar Servicing Details-->\n" + carService.GetDetails() +"\n");
        }
    }
}
