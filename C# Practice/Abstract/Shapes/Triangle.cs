using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.Shapes
{
    public class Triangle : AShapes
    {
        private double _breadth = 23;
        private double _height = 12;
        public override double Area()
        {
            double area = 0.5 * _breadth * _height;
            return area;
        }
    }
}
