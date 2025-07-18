using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation4Example
{
    class Circle:Shape
    {
        private double r;
        public double R
        {
            get
            {
                return r;
            }set => r = value;
        }
        public Circle(string name, int numberOfSides,string type, double r)
            : base(name, numberOfSides, type)
        {
            this.r = r;
        }
        public override double calculateArea()
        {
            return Math.PI * r * r;
        }

        public override double calculatePerimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}
