using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation1
{
    class Building
    {
        //area
        private double area;
        public double Area
        {
            get { return area; }
            set => area = value;
        }
        private string color;
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
       // House h1 = new House(5, 25.4, 2.3, "red", "Peter");

        private House h2;
        public House H2
        {
            get
            {
                return h2;
            }
            set
            {
                h2 = value;
            }
        }
        //house
        //color

        public Building(string color, double area, House h2)
        {
            this.color = color;
            this.area = area;
            this.h2 = h2;
        }

        public void returnBuildingInfo()
        {
            Console.WriteLine("Building color: "+color);
            Console.WriteLine("Building area: "+area);
            Console.WriteLine("House info: ");
            h2.returnHouseInfo();
        }

        
    }
}
