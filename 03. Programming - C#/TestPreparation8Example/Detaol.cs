
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation8Example
{
    class Details
    {
       private  double width;
        private double height;
       private double length;

        public Details(double width, double height,double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }
        public override string ToString()
        {
            return "Width: " + width + ". Height: " + height + ". Length: " + length+".";
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

    }
}
