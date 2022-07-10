using System;
using System.Collections.Generic;
using System.Text;

namespace tgl_pract1.Models
{
    class Square2 : Figure
    {
        public double A { get; }

        public Square2(double a)
        {
            A = a;
        }

        public override double CalculateArea()
        {
            return Math.Pow(A, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * A;
        }
    }
}
