using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class Equllateral : Triangle, IShapeData
    {
        public Equllateral(double SideLength1) : base(SideLength1)
        {
        }
        public double GetArea()
        {
            double sqrd3 = Math.Sqrt(3);
            double fraction = sqrd3 / 4;
            double side1sqrd = SideLength1 * SideLength1;
            double awnser = fraction * side1sqrd;
            return Math.Round(awnser, 2);
        }
        public double GetPerimeter()
        {
            return SideLength1 * 3;
        }

    }
}
