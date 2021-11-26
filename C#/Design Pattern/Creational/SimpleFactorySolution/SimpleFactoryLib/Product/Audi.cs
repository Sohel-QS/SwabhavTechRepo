using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    internal class Audi : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Manufacturing Audi Started");
        }

        public void Stop()
        {
            Console.WriteLine("Manufacturing Audi Stoped");
        }
    }
}
