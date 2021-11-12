using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorOOADApp.Model
{
    class ConsolePrinter
    {
        public void OpenedDoor()
        {
            Console.WriteLine("The Dog Door Opens.");
        }
        public void ClosedDoor()
        {
            Console.WriteLine("The Dog Door Closes.");
        }
        public void PressingButton()
        {
            Console.WriteLine("Pressing Remote Control Button ...");
        }
        public void HeardBark(string bark)
        {
            Console.WriteLine("\tBarkRecognizer: Heard a '{0}'", bark);
        }
    }
}
