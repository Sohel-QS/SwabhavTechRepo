using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTestApp
{
    public struct Rectangle
    {
        public int width;
        public int height;
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Rectangle r;
            r.width = 10;
            r.height = 6;

            Console.WriteLine("Rectangle\nWidth:{0}\nHeight:{1}\nArea:{2}", r.width, r.height, (r.width * r.height));
        }
    }
}
