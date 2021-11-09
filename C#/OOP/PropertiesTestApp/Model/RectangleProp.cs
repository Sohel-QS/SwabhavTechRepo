using System;

namespace PropertiesTestApp.Model
{
    class RectangleProp
    {
        private readonly int _width;
        private readonly int _height;
        private string _fillColor;
        private string _borderColor;

        public RectangleProp(int width, int height, string fillColor, string borderColor)
        {
            _width = width;
            _height = height;
            _fillColor = fillColor;
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

        public void SetFillColor(string fillColor)
        {
            _fillColor = fillColor;
        }
        public string GetFillColor()
        {
            return _fillColor;
        }

        public void SetBorderColor(string borderColor)
        {
            _borderColor = borderColor;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
    }
}
