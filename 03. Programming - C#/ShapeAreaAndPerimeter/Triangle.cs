using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAreaAndPerimeter
{
    internal class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(string type, int countOfSides, double a, double b, double c)
            :base(type, countOfSides)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set
            {
                a=value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public override double calculateArea()
        {
            double p = calculatePerimeter() / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public override double calculatePerimeter()
        {
            return a+b+c;
        }
    }
}
