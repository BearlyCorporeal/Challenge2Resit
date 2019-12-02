using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class RightAngle : Triangle, IShapeData
    {
        public RightAngle(double SideLength1, double SideLength2) : base(SideLength1, SideLength2)
        {
        }
        public double GetHypotenuse()
        {
            double side1sqrd = SideLength1 * SideLength1;
            double side2sqrd = SideLength2 * SideLength2;
            double side3sqrd = side1sqrd + side2sqrd;
            return Math.Sqrt(side3sqrd);
        }
        public double GetArea()
        {
            double sidelenghts = SideLength1 * SideLength2;
            double awnser = sidelenghts / 2;
            return awnser;
        }
        public double GetPerimeter()
        {
            double side3 = this.GetHypotenuse();
            double awnser = SideLength1 + SideLength2 + side3;
            return Math.Round(awnser,2);
        }
        public RightAngle() : base()
        {
        }
    }
}
