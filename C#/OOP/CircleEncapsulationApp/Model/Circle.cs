using System;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private const float pi = 3.142f;
        private float _radius = 1.0f;
        private int lowerBound = 1;
        private int upperBound = 10;
        private string _borderColor = "red";
        private string _fillColor = "red";
        private string[] _availColor = { "red", "green", "blue"};
        private string _defaultColor = "red";

        public void SetRadius(float radius)
        {
            _radius = GetCorrectDimension(radius);
        }
        public void SetBorderColor(string borderColor)
        {
            _borderColor = GetCorrectColor(borderColor.ToLower());
        }
        public void SetFillColor(string fillColor)
        {
            _fillColor = GetCorrectColor(fillColor.ToLower());
        }

        public float GetRadius()
        {
            return _radius;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
        public string GetFillColor()
        {
            return _fillColor;
        }

        private float GetCorrectDimension(float rad)
        {
            if (rad < 1)
                return lowerBound;
            else if (rad > 10)
                return upperBound;
            else
                return rad;
        }

        private string GetCorrectColor(string color)
        {
            if (Array.Exists(_availColor, x => x == color))
                return color;
            else
                return _defaultColor;
        }

        public float CalculateArea()
        {
            return pi * _radius * _radius;
        }
    }
}
