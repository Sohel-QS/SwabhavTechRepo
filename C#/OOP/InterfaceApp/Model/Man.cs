using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Man : IManner
    {
        public void Depart()
        {
            Console.WriteLine("{0} Departing...", this);
        }

        public void Wish()
        {
            Console.WriteLine("{0} Wishing...", this);
        }

        public override string ToString()
        {
            return "Man";
        }
    }
}
