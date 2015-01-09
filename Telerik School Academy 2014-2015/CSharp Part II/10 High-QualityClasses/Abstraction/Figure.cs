using System;

namespace Abstraction
{
    abstract class Figure
    {
        public virtual double Width { get; private set; }
        public virtual double Height { get; private set; }
        public virtual double Radius { get; private set; }

        
        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public virtual double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
