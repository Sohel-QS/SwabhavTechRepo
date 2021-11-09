using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy : IManner, IEmotion
    {
        public void Cry()
        {
            Console.WriteLine("{0} Crying...", this);
        }

        public void Laugh()
        {
            Console.WriteLine("{0} Laughing...", this);
        }

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
            return "Boy";
        }
    }
}
