using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Sqrt(this.Radius);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string Draw()
        {
            return $"Draw Circle";
        }
    }
}
