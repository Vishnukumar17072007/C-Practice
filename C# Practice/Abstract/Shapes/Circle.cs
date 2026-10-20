using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.Shapes.Shapes
{
    public class Circle : AShapes
    {
        private double _radius = 5;
        public override double Area()
        {
            double area = 3.14 * _radius * _radius;
            return area;
        }
    }
}
