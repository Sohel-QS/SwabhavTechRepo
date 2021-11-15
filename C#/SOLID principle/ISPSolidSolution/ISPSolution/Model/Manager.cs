using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolution.Interface;

namespace ISPSolution.Model
{
    class Manager : IWorker, IWorkable, IEatable
    {
        public void Message()
        {

            Console.WriteLine("Manager is Workable and Eatable");
        }

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
