 using System;

namespace TestPreparation1
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(5, 25.4, 2.3, "red", "Peter");
            Building b1 = new Building("red", 74.3, h1);
            b1.returnBuildingInfo();
        }
    }
}
