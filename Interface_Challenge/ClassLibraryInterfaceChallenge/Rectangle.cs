using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class Rectangle : Quadrilateral
    {

        public Rectangle(double SideLength1, double SideLength2) : base(SideLength1, SideLength2)
        {

        }
        public Rectangle() : base()
        {

        }
        public override double GetArea()
        {
            return SideLength1 * SideLength2;
        }
        public override double GetPerimeter()
        {
            return SideLength1 + SideLength1 + SideLength2 + SideLength2;
        }

    }



}
