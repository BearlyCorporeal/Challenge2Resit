using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class Circle : Shape, IShapeData
    {
        double pi = 3.142;
        double radius;

        public Circle(double radius) : base()
        {
            this.radius = radius;
        }
        public Circle() : base()
        {
        }
        public double GetArea()
        {
            double awnser = pi * radius * radius;
            return Math.Round(awnser, 2);
        }
        public double GetPerimeter()
        {
            double awnser = 2 * pi * radius;
            return Math.Round(awnser,2);
        }
    }
}
