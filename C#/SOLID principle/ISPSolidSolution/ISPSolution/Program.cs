using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolution.Interface;
using ISPSolution.Model;

namespace ISPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();

            AtTheWorkStation(manager);
            AtTheWorkStation(robot);

            AtTheCafeteria(manager);
            AtTheCafeteria(robot);
        }

        private static void AtTheWorkStation(IWorkable worker)
        {
            Console.WriteLine("\nAt The Work Station :");
            worker.StartWork();
            worker.StopWork();
        }

        private static void AtTheCafeteria(IEatable worker)
        {
            Console.WriteLine("\nAt The Cafeteria :");
            worker.StartEat();
            worker.StopEat();
        }
    }
}
