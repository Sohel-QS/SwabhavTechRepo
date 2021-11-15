using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolution.Interface;

namespace ISPSolution.Model
{
    class Robot : IWorkable
    {
        public void Message()
        {
            Console.WriteLine("Robot is Workable");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot Start Working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stop Working");
        }
    }
}
