using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Factory;

namespace SimpleClientFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
        }

        private static void Part2()
        {
            var factory1 = AutoMobileFactory.GetInstance();
            var auto1 = factory1.Make(AutoType.AUDI);

            Console.WriteLine("Hash Code of First Object :{0}",
                factory1.GetHashCode());
            auto1.Start();
            auto1.Stop();

            Console.Write("\n");

            var factory2 = AutoMobileFactory.GetInstance();
            var auto2 = factory2.Make(AutoType.TESLA);

            Console.WriteLine("Hash Code of Second Object :{0}",
                factory2.GetHashCode());
            auto2.Start();
            auto2.Stop();
        }

        private static void Part1()
        {
            //var audi = new Audi();

            var factory = new AutoMobileFactory();
            var auto = factory.Make(AutoType.AUDI);

            auto.Start();
            auto.Stop();
        }
    }
}
