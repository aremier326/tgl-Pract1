using System;
using System.Collections.Generic;
using System.Text;

namespace tgl_pract1.Models
{
    class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public new string ToString()
        {
            return $"Perimeter of circle: {CalculatePerimeter()}\t Area: {CalculateArea()}";
        }
    }
}
