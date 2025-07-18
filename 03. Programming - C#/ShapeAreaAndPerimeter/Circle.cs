using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAreaAndPerimeter
{
    class Circle: Shape
    {
        private double r;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public Circle(string type, int countOfSides, double r) 
        :base(type, countOfSides){
            this.r = r;
        }

        public override double calculateArea()
        {
            return Math.PI*r*r;
        }

        public override double calculatePerimeter()
        {
            return 2*Math.PI*r;
        }
    }
}
