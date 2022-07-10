using System;
using System.Collections.Generic;
using tgl_pract1.Models;

namespace tgl_pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>()
            {
                new Circle(5),
                new Rectangle(1, 5),
                new Square1(19),
                new Square2(3),
                new Triangle(2, 6, 3)
            };

            foreach (var f in figures)
            {
                Console.WriteLine(f);
            }

 
        }
    }
}
