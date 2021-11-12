using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorOOADApp.Model
{
    class DogDoor
    {
        private bool _open;
        private const int _time = 5000;
        ConsolePrinter print = new ConsolePrinter();
        public DogDoor()
        {
            this._open = false;
        }

        public void Open()
        {
            print.OpenedDoor();
            _open = true;
            this.ScheduledTask();

        }

        private void ScheduledTask()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(_time);
                this.Close();
            }
               );
        }

        public void Close()
        {
            print.ClosedDoor();
            _open = false;
        }

        public bool IsOpen()
        {
            return _open;
        }
    }
}
