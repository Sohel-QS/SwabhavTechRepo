using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogDoorOOADApp.Model
{
    class Remote
    {
        private DogDoor _door;
        ConsolePrinter print = new ConsolePrinter();

        public Remote(DogDoor door)
        {
            this._door = door;
        }

        public void PressButton()
        {
            print.PressingButton();
            if(_door.IsOpen())
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }   
        }
    }
}
