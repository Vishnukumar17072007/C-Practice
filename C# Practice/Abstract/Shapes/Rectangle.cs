using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.Shapes
{
    public class Rectangle : AShapes
    {
        private double _length = 10;
        private double _breadth = 5;
        public override double Area()
        {
            double area = _length * _breadth;
            return area;
        }
    }
}
