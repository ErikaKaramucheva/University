using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation4Example
{
    abstract class Shape
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int numberOfSides;
        public int NumberOfSides
        {
            get
            {
                return numberOfSides;
            }
            set
            {
                numberOfSides = value;
            }
        }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public abstract double calculateArea();
        public abstract double calculatePerimeter();

        public Shape(string name, int numberOfSides,string type)
        {
            this.name = name;
            this.numberOfSides = numberOfSides;
            this.type = type;
        }
    }
}
