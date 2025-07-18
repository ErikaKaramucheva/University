using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation5Example
{
    internal class Circle : Shape
    {
        public Circle(string type,double a)
            : base(type, a)
        {

        }
        public override double calculateArea()
        {
            return Math.PI * A * A;
        }

        public override double calculatePerimeter()
        {
            return 2 * Math.PI * A;
        }
    }
}
