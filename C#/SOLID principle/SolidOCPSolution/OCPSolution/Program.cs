using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolution.Client;

namespace OCPSolution.Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Sohel",100000,5,new DivaliFestivalPolicy());
            Console.WriteLine("Simple Interest With Divali Festival Policy :Rs.{0}", fd1.SimpleInterest());


            var fd2 = new FixedDeposit("Sohel", 100000, 5, new NormalPolicy());
            Console.WriteLine("\nSimple Interest With Normal Policy :Rs.{0}", fd2.SimpleInterest());
        }
    }
}
