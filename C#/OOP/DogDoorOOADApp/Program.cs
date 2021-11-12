using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogDoorOOADApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            var recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Fido Starts Barking.");
            recognizer.Recognize("Woof");

            Console.WriteLine("\nFido has gone outside....");
            Console.WriteLine("\nFido's all done....");

            try
            {
                Thread.Sleep(10000);
            }
            catch(ThreadInterruptedException)
            {

            }

            Console.WriteLine("...but he's stuck outside !");
            Console.WriteLine("Fido starts barking.");

            recognizer.Recognize("Woof");

            Console.WriteLine("\nFido's back inside ....");
            try
            {
                Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException)
            {

            }
        }
    }
}
