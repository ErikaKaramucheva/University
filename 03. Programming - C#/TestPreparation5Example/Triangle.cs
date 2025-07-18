using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation5Example
{
    class Triangle:Shape
    {
        private double b;
        public double B
        {
            get
            {
                return b;
            }set => b = value;
        }
        private double c;
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        private double ha;
        public double Ha
        {
            get
            {
                return ha;
            }
            set
            {
                ha = value;
            }
        }

        public Triangle(string type, double a, double b, double c, double ha)
            :base(type, a)
        {
            this.b = b;
            this.c = c;
            this.ha = ha;
        }

        public override double calculateArea()
        {
           return (A*ha)/2;
        }

        public override double calculatePerimeter()
        {
            return A+b+c;
        }
    }
}
