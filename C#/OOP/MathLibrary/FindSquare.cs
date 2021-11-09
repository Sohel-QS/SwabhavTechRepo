using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class FindSquare
    {
        public double Square(double num)
        {
            return Math.Round(num * num,2);
        }
        public double Square(int num)
        {
            return num * num;
        }
        public double Square(float num)
        {
            return Math.Round(num * num, 2);
        }
    }
}
