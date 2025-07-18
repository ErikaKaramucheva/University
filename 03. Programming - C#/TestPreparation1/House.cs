using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation1
{
    class House
    {
        //house-rooms,area(sum of area of all rooms),height,color,owner
        private int rooms;
        public int Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
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

        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height= value;
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

        private string name;



        public string Name
        {
            get
            {
                return name;
            }
            set=> name = value;
            
        }

        public House(int rooms, double area, double height, string color, string name)
        {
            this.rooms = rooms;
            this.area = area;
            this.height = height;
            this.color=color;
            this.name = name;
        }

        public void returnHouseInfo()
        {
            Console.WriteLine("This house has: "+rooms+" rooms.");
            Console.WriteLine("This house has: "+area+" area.");
            Console.WriteLine("Height: "+height);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("Owner's name: "+name);
        }

    }
}
