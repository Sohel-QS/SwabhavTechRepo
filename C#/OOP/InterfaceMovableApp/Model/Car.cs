using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMovableApp.Model
{
    class Car : IMovable
    {
        public void MoveVehical()
        {
            Console.WriteLine("Car is Moving");
        }
    }
}
