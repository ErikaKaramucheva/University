using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation4Example
{
    class Rectangle:Shape
    {
        private double a;
        public double A
        {
            get
            {
                return a;
            }set => a = value;
        }
        private double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public Rectangle(string name, int numberOfSides,string type, double a, double b)
            :base(name, numberOfSides,type)
        {
            this.a = a;
            this.b = b;
        }
        public override double calculateArea()
        {
            return a * b;
        }

        public override double calculatePerimeter()
        {
            return 2 * (a + b);
        }
    }
}
