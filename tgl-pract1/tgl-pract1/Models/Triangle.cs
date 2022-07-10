using System;
using System.Collections.Generic;
using System.Text;

namespace tgl_pract1.Models
{
    public class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculatePerimeter()
        {
            return A + B + C;
        }

        public override double CalculateArea()
        {
            var s = CalculatePerimeter() / 2;

            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override string ToString()
        {
            return $"Perimeter of triangle: {CalculatePerimeter()}\t Area: {CalculateArea()}";
        }

    }
}
