using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation5Example
{
    abstract class Shape
    {
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
        private double a;
        public double A
        {
            get
            {
                return a;
            }set => a = value;
        }

        public Shape(string type,double a)
        {
            this.type = type;
            this.a = a;
        }

        public abstract double calculatePerimeter();
        public abstract double calculateArea();
    }
}
