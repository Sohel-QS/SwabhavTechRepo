using System;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Account acc1 = new Account(10001, "Sohel", 2000);
            Account acc2 = new Account(10001, "Sohel", 2000);

            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());

            Console.WriteLine(acc1==acc2);
            Console.WriteLine(acc1.Equals(acc2));
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(1001,"sohel", 2000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());
        }
    }
}
