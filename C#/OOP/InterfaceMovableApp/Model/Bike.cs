using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMovableApp.Model
{
    class Bike : IMovable
    {
        public void MoveVehical()
        {
            Console.WriteLine("Bike is Moving");
        }
    }
}
