using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolation.Interface;

namespace ISPViolation.Model
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manager is Eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager is Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager Stop Eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager Stop Working");
        }
    }
}
