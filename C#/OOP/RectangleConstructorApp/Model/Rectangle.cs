using System;

namespace RectangleConstructorApp.Model
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _fillColor;
        private string _borderColor;

        public Rectangle(int width, int height, string fillcolor)
        {
            _width = width;
            _height = height;
            _fillColor = fillcolor;
        }

        public Rectangle(int width, int height, string fillcolor, string borderColor)
        {
            _width = width;
            _height = height;
            _fillColor = fillcolor;
            _borderColor = borderColor;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public string GetFillColor()
        {
            return _fillColor;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }

        public int CalculateArea()
        {
            return _width * _height;
        }
    }
}
