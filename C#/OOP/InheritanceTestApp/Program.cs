using System;

namespace InheritanceTestApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();
        }

        private static void CaseStudy5()
        {
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "hello World";
            Console.WriteLine(x.GetType());
            x = 10.55f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());

        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
            Console.WriteLine("\n");
        }

        private static void AtThePark(Man x)
        {
            Console.Write("At the Park ");
            x.Play();
        }

        private static void CaseStudy3()
        {
            Man x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
            Console.WriteLine("\n");
        }

        private static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.Jump();
            y.Walk();
            y.Read();
            Console.WriteLine("\n");
        }

        private static void CaseStudy1()
        {
            Man x;
            x = new Man();
            x.Walk();
            x.Play();
            x.Read();
            Console.WriteLine("\n");
        }
    }
}
