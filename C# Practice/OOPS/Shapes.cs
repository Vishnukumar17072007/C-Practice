using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace C__Practice.OOPS
{
    public abstract class Shapes
    {
        public abstract double Area();
    }

    public class Circle : Shapes
    {
        private double _radius = 5;
        public override double Area()
        {
            double area = 3.14 * _radius * _radius;
            return area;
        }
    }

    public class Rectangle : Shapes
    {
        private double _length = 10;
        private double _breadth = 5;
        public override double Area()
        {
            double area = _length * _breadth;
            return area;
        }
    }

    public class Triangle : Shapes
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
