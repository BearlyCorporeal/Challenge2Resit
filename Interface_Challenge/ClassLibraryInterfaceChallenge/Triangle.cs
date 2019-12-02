using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class Triangle : Shape
    {
        public Double SideLength1;
        public Double SideLength2;
        public Double SideLength3;
        public Triangle():base()
        {
            
        }
        public Triangle(double SideLength1): base()
        {
            this.SideLength1 = SideLength1;
        }
        public Triangle(double SideLength1, double SideLength2):base()
        {
            this.SideLength1 = SideLength1;
            this.SideLength2 = SideLength2;
        }
    }
}
