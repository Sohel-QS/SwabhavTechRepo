using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    internal class Bmw : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Manufacturing Bmw Started");
        }

        public void Stop()
        {
            Console.WriteLine("Manufacturing Bmw Stoped");
        }
    }
}
