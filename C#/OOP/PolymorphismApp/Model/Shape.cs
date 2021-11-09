using System;

namespace PolymorphismApp.Model
{
    class Shape
    {
        public virtual string Draw()
        {
            return "Drawing Shape";
        }
    }
    class Rectangle : Shape
    {
        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }
    }
    class Circle : Shape 
    {
        public override string Draw()
        {
            return base.Draw() + " Circle";
        }
    }
}
