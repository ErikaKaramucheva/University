using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation7Example
{
    abstract class Room
    {
        private  static double _area;
        public static double Area {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
            
        }
        private string color;
        public string Color
        {
            get
            {
                return color;
            }set => color = value;
        }

        public Room(double area,string color)
        {
            _area = area;
            this.color = color;
        }
    }
}
