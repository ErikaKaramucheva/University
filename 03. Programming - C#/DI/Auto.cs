using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    enum Motor { diesel, gasoline };
    class Auto
    {
        private string regNumber;
        private string make;
        private string model;
        private string color;
        private int price;
        private int year;
        private Motor motor;

        public Auto(string regNumber, string make, string model, string color, int price, int year, Motor motor)
        {
            this.regNumber = regNumber;
            this.make = make;
            this.model = model;
            this.color = color;
            this.price = price;
            this.year = year;
            this.motor = motor;
        }

        public string RegNumber { get { return regNumber; } set => regNumber = value; }
        public string Make { get { return make; } set => make = value; }
        public string Model { get { return model; } set => model = value; }
        public string Color { get { return color; } set => color = value; }
        public int Price { get { return price; } set => price = value; }
        public int Year { get { return year; } set => year = value; }

        public override string ToString()
        {
            return "Registration number: " + regNumber + ".\n Make: " + make + ".\n Model: " + model + ".\n Color: " + color + ".\n Price: " + price + ".\n Year: " + year;
        }
    }
    }
