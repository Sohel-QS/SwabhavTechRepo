using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Interface;

namespace LSPSolution.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 30);

            WhenHeightIsChangedWidthShouldNotBeChange(rectangle);


            IPolygon square = new Square(20);

            WhenHeightIsChangedWidthShouldNotBeChange(square);
        }

        private static void WhenHeightIsChangedWidthShouldNotBeChange(Rectangle rectangle)
        {
            int before = rectangle.Width;

            rectangle.Height = rectangle.Height + 10;

            int after = rectangle.Width;

            Console.WriteLine("Is Width Changed :{0}", before != after);
            Console.WriteLine("Before Changing Height Width is :{0}", before);
            Console.WriteLine("After Changing Height Width is:{0}\n", after);
        }
    }
}
