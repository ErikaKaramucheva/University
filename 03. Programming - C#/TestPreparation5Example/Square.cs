using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation5Example
{
    class Square : Shape
    {
        public Square(string type, double a)
            : base(type, a)
        {

        }
        
        public override double calculateArea()
        {
            return A * A;
        }

        public override double calculatePerimeter()
        {
            return 4 * A;
        }
    }
}
