using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public abstract class Quadrilateral : Shape, IShapeData
    {
        public Double SideLength1;
        public Double SideLength2;
        public Double SideLength3;
        public Double SideLength4;
        public Quadrilateral(double SideLength1)
        {
            this.SideLength1 = SideLength1;
        }
        public Quadrilateral(double SideLength1, double SideLength2) : base()
        {
            this.SideLength1 = SideLength1;
            this.SideLength2 = SideLength2;
        }
        public Quadrilateral()
        {
        }
        public abstract double GetPerimeter();
        public abstract double GetArea();

    }
}
