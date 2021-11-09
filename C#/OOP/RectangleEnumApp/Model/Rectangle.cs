using System;

namespace RectangleEnumApp.Model
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private ColorType _borderColor;
        Program obj = new Program();
        public Rectangle()
        {
            obj.Display();
            _width = 1;
            _height = 1;
            _borderColor = ColorType.RED;
        }

        public int Height
        {
            get{
                return _height;
            }
            set{
                _height = GetCorrectDimension(value);
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = GetCorrectDimension(value);
            }
        }

        public ColorType BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
            }
        }

        public int Area {
            get
            {
                return _width * _height;
            }
        }

        private int GetCorrectDimension(int value)
        {
            if (value < 1)
                return 1;
            else if (value > 100)
                return 100;
            else
                return value;
        }
    }
}
