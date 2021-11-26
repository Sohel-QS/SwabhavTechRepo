using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternApp.Model
{
    class ProxyImage : IImage
    {
        private string _fileName;

        private RealImage _realImage;

        public ProxyImage(string name)
        {
            _fileName = name;
        }
        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }
}
