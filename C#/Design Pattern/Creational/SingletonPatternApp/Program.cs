using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPatternApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();

            //Part2();

            Part4();
        }

        private static void Part4()
        {
            Thread t1 = new Thread(()=> 
            {
                DataService.GetInstance().DoSomething();
            });

            Thread t2= new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });

            t1.Start();
            t2.Start();
        }

        private static void Part2()
        {
            var sv1 = DataService.GetInstance();
            var sv2 = DataService.GetInstance();

            Console.WriteLine("Service 1 Hash Code :" + sv1.GetHashCode());
            Console.WriteLine("Service 2 Hash Code :" + sv2.GetHashCode());
        }

        //private static void Part1()
        //{
        //    var sv1 = new DataService();
        //    var sv2 = new DataService();

        //    Console.WriteLine("Service 1 Hash Code :" + sv1.GetHashCode());
        //    Console.WriteLine("Service 2 Hash Code :" + sv2.GetHashCode());

        //    sv1.DoSomething();
        //    sv2.DoSomething();
        //}
    }
}
