using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorOOADApp.Model
{
    class BarkRecognizer
    {
        private DogDoor _door;
        ConsolePrinter print = new ConsolePrinter();
        public BarkRecognizer(DogDoor door)
        {
            this._door = door;
        }

        public void Recognize(string bark)
        {
            print.HeardBark(bark);
            _door.Open();
        }
    }
}
