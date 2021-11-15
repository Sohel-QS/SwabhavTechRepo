using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolation.Interface;

namespace ISPViolation.Model
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("ISP Violation");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot is Working");
        }

        public void StopEat()
        {
            Console.WriteLine("ISP Violation");
        }

        public void StopWork()
        {Console.WriteLine("Robot Stops Working");
        }
    }
}
