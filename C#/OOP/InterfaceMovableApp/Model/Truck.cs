using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMovableApp.Model
{
    class Truck : IMovable
    {
        public void MoveVehical()
        {
            Console.WriteLine("Truck is Moving");
        }
    }
}
