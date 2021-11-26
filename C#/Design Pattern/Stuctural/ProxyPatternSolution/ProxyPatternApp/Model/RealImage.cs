using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp.Model
{
    class RealImage:IImage
    {
        private string _fileName;

        public RealImage(string name)
        {
            _fileName = name;
            Console.WriteLine("Loading Image {0}",_fileName);
        }

        public void Display()
        {
            Console.WriteLine("DisplayingImage {0}", _fileName);
        }
    }
}
