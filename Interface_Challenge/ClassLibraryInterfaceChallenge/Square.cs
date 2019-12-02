using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class Square : Quadrilateral
    {
        public Square(double SideLength1) : base(SideLength1)
        {
        }
        public Square() : base()
        {
        }
        public override double GetArea()
        {
            return SideLength1 * SideLength1;
        }
        public override double GetPerimeter()
        {
            return SideLength1 * 4;
        }
    }
}
