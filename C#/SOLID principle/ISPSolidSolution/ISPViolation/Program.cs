using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolation.Interface;
using ISPViolation.Model;

namespace ISPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker manager = new Manager();
            IWorker robot = new Robot();

            AtTheWorkStation(manager);
            AtTheWorkStation(robot);

            AtTheCafeteria(manager);
            AtTheCafeteria(robot);
        }

        private static void AtTheWorkStation(IWorker worker)
        {
            Console.WriteLine("\nAt The Work Station :");
            worker.StartWork();
            worker.StopWork();
        }

        private static void AtTheCafeteria(IWorker worker)
        {
            Console.WriteLine("\nAt The Cafeteria :");
            worker.StartEat();
            worker.StopEat();
        }
    }
}
