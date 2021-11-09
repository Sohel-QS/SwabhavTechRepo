using System;

namespace RactangleAbstractionApp.Model
{
    class Rectangle
    {
        public int width;
        public int height;

        public int CalculateArea()
        {
            int rectangleArea;
            rectangleArea = width * height;
            return rectangleArea;
        }


    }
}
