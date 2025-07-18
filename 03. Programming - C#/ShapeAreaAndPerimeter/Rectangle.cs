using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAreaAndPerimeter
{
    class Rectangle: Shape
    {
        private double a;
        private double b;
        public double A
        {
            get
            {
                return a;
            }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Rectangle(string type, int countOfSides, double a, double b)
            :base(type, countOfSides)
        {
            this.a = a;
            this.b = b;
        }

        public override double calculateArea()
        {
            return a * b; ;
        }

        public override double calculatePerimeter()
        {
            return 2*(a+b);
        }
    }
}
