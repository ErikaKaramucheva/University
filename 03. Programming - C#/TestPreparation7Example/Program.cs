
using System;
using System.Collections.Generic;

namespace TestPreparation7Example
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(2, 2.8, "yellow", "Peter");
            House h2 = new House(3, 3.4, "green", "Maria");
            House h3 = new House(5, 12.8, "whitew", "Nikola");

            
            Bathroom bath1 = new Bathroom(12, "RED");
            Bathroom bath2 = new Bathroom(7, "pink");
            Bedroom bed1 = new Bedroom(15, "blue");
            Bedroom bed2 = new Bedroom(11, "black");
            Kitchen kit1 = new Kitchen(30, "purple");
            
            
            h1.all.Add(bath1);
            h2.all.Add(bath2);
            h1.all.Add(bed1);
            h1.all.Add(bed2);
            h1.all.Add(kit1);

          

            House[] building = { h1, h2, h3 };

            for (int i = 0; i < building.Length; i++)
            {
               
                building[i].returnBuildingInfo(building[i],);

            }
            

        }

    }
}
