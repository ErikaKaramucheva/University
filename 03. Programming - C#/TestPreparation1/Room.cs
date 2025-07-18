using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation1
{
    abstract class Room
    {
        private int area;
        public int Area
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

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Room(int area, string color)
        {
            this.area = area;
            this.color = color;

        }

       // double allArea;
       // public abstract void allAreas(double allArea);
        //bathroom,kitchen,bedroom,
        //building-area,height,color
        //house-rooms,rea(sum of area of all rooms),height,color,owner
        //print-building
    }
}
