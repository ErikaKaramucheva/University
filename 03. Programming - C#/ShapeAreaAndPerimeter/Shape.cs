using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeAreaAndPerimeter
{
    public abstract class Shape
    {
        private string type;
        private int countOfSides;

        public int CountOfSides { 
            get { return countOfSides; } 
            set {countOfSides=value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Shape(string type, int countOfSides)
        {
            this.type = type;
            this.countOfSides = countOfSides;
        }
        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    }
}
