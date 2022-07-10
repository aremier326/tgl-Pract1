using System;
using System.Collections.Generic;
using System.Text;

namespace tgl_pract1.Models
{
    public class Rectangle : Figure
    {
        public double A { get; }

        public double B { get; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double CalculateArea()
        {
            return A * B;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (A + B);
        }

        public override string ToString()
        {
            return $"Perimeter of rectangle: {CalculatePerimeter()}\t Area: {CalculateArea()}";
        }
    }
}
