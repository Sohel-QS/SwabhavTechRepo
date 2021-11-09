using System;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;
        private int lowerBound = 1;
        private int upperBound = 100;

        public void SetWidth(int pWidth)
        {
            width = GetCorrectDimension(pWidth);
        }
        public void SetHeight(int pHeight)
        {
            height = GetCorrectDimension(pHeight);
        }

        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }

        private int GetCorrectDimension(int dimension)
        {
            
            if (dimension < lowerBound)
                return lowerBound;
            else if(dimension > upperBound)
                return upperBound;
            else 
                return dimension;
        }
    }
}
