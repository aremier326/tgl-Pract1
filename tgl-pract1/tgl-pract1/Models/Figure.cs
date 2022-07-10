using System;
using System.Collections.Generic;
using System.Text;

namespace tgl_pract1.Models
{
    public abstract class Figure
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return $"Perimeter: {CalculatePerimeter()}\t Area: {CalculateArea()}";
        }
    }
}
