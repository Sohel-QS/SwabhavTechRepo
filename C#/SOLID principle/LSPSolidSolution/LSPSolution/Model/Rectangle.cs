using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Interface;

namespace LSPSolution.Model
{
    class Rectangle : IPolygon
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int _height)
        {
            this._width = width;
            this._height = _height;
        }

        public int Width 
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public void CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
