using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation7Example
{
    class House:Person
    {
        private static int rooms;
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
     
        private double height;
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

         public List<Room> all { get; set; } = new List<Room>(rooms);



        public House(int rooms, double height, string color,string name)
            : base(name)
        {
            this.Rooms = rooms;
            this.height = height;
            this.color = color;
           
        }


        public double returnAllRoomsArea(List<Room> all)
        {

            double area = 0;
            for(int i = 0; i < all.Count; i++)
            {
                area =area+Room.Area;
                Console.WriteLine(area);
            }
           return area;

        }
        public void returnBuildingInfo(House h, double hArea)
        {
            Console.WriteLine("Area: " + hArea);
            Console.WriteLine("Height: " + h.Height);
            Console.WriteLine("Color: " + h.Color);
            Console.WriteLine();

        }
    }
}
