using System;

namespace InterfaceMovableApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movable = new IMovable[5];

            movable[0] = new Car();
            movable[1] = new Bike();
            movable[2] = new Truck();
            movable[3] = new Bike();
            movable[4] = new Car();

            StartRace(movable);

        }

        private static void StartRace(IMovable[] movable)
        {
            Console.WriteLine("Race has been Started ");
            foreach(IMovable vehical in movable)
            {
                vehical.MoveVehical();
                Console.Write("\n");
            }
        }
    }
}
