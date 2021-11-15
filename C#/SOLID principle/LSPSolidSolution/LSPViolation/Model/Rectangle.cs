using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation.Model
{
    class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width,int height)
        {
            this._width = width;
            this._height = height;
        }

        virtual public int Width
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

        virtual public int Height
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

        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }
    }
}
