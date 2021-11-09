using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            M1();

            Console.WriteLine("\nEnd of Main");
        }

        private static void M1()
        {
            Console.WriteLine("Inside M1\n");
            M2();
        }

        private static void M2()
        {
            Console.WriteLine("Inside M2\n");
            try
            {
                M3();
            }
            catch(Exception exc)
            {

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(exc.Message);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(exc.StackTrace);
            }
        }

        private static void M3()
        {
            Console.WriteLine("Inside M3\n");

            throw new Exception("Something Went Wrong!!!");
        }
    }
}
