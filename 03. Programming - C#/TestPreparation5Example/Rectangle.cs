using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation5Example
{
    class Rectangle:Shape
    {
        private double b;
        public double B
        {
            get
            {
                return b;
            }set => b = value;
        }

        public Rectangle(string type, double a, double b)
            :base(type, a)
        {
            this.b = b;
        }

        public override double calculatePerimeter()
        {
            return 2 * (A + b);
        }

        public override double calculateArea()
        {
            return A * b;
        }
    }
}
