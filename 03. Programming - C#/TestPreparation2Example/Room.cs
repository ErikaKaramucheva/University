using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation2Example
{
    abstract class Room
    {
        private int beds;
        public int Beds
        {
            get
            {
                return beds;
            }
            set
            {
                beds = value;
            }
        }
        private double area;
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        public Room(int beds,double area)
        {
            this.beds = beds;
            this.area = area;
        }
    }
}
