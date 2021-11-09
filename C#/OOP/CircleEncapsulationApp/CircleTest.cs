using System;

namespace CircleEncapsulationApp.Model
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            Circle crl1 = new Circle();
            Circle[,] manyCircles = new Circle[2,2];

            crl1.SetRadius(3.4f);
            crl1.SetBorderColor("red");
            crl1.SetFillColor("blue");

            manyCircles[0,0] = crl1;

            manyCircles[0,1] = new Circle();

            manyCircles[0,1].SetRadius(4.5f);
            manyCircles[0,1].SetBorderColor("blue");
            manyCircles[0,1].SetFillColor("green");

            manyCircles[1,0] = new Circle();

            manyCircles[1,0].SetRadius(5.4f);
            manyCircles[1,0].SetBorderColor("green");
            manyCircles[1,0].SetFillColor("blue");

            manyCircles[1, 1] = new Circle();

            manyCircles[1, 1].SetRadius(6.5f);
            manyCircles[1, 1].SetBorderColor("green");
            manyCircles[1, 1].SetFillColor("red");

            Console.WriteLine("Case Study 3:");
            Console.WriteLine(">>>Values of Circle Array ");
            PrintDetails(manyCircles);
            PrintTheBiggestCircle(manyCircles);
        }

        private static void CaseStudy2()
        {
            Circle c1 = new Circle();

            Console.WriteLine("Case Study 2:");

            Console.WriteLine("Area of anonymous circle object is :{0}", new Circle().CalculateArea());

            Console.WriteLine("Border color of anonymous circle object is :{0}", new Circle().GetBorderColor());

            PrintDetails(new Circle());
        }

        public static void CaseStudy1()
        {
            Circle c1 = new Circle();

            Console.WriteLine("Case Study 3:");

            PrintDetails(c1);

            c1.SetRadius(5.5f);
            c1.SetBorderColor("Blue");
            c1.SetFillColor("Red");
            PrintDetails(c1);

            c1.SetRadius(-5.5f);
            c1.SetBorderColor("Yellow");
            c1.SetFillColor("red");
            PrintDetails(c1);

            c1.SetRadius(5.5f);
            c1.SetBorderColor("GrEEn");
            c1.SetFillColor("BluE");
            PrintDetails(c1);
        }

        static void PrintDetails(Circle c)
        {
            Console.WriteLine("Values Are :\nRadius :{0}\nBorder Color :{1}\nFill Color :{2}\nArea :{3}\n"
                , c.GetRadius(), c.GetBorderColor(), c.GetFillColor(), c.CalculateArea());
        }

        static void PrintDetails(Circle[,] circles)
        {
            foreach(Circle circle in circles)
            {
                PrintDetails(circle);
            }
        }

        static void PrintTheBiggestCircle(Circle[,] circles)
        {
            Circle bigCircle = CheckMaxRadius(circles);
            Console.Write(">>>Big Circle ");
            PrintDetails(bigCircle);
        }

        private static Circle CheckMaxRadius(Circle[,] circles)
        {
            float max = 0;
            Circle bigCircle = new Circle();

            foreach(Circle circle in circles)
            {
                if (max < circle.GetRadius())
                    max = circle.GetRadius();
            }

            foreach(Circle circle in circles)
            {
                if (max.Equals(circle.GetRadius()))
                {
                    bigCircle = circle;
                }
            }
            return bigCircle;
        }
    }
}
