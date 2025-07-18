using System;
using System.Collections.Generic;

namespace TestPreparation2Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Rooms r1 = new Rooms(2, 15.4, true);
            Rooms r2 = new Rooms(1, 13.2, false);

            Apartment a1 = new Apartment(6, 35, true, "President Apartment");
            Apartment a2 = new Apartment(4, 25.7, false, "Residental Apartment");

            List<Room> r = new List<Room>();
            r.Add(r1);
            r.Add(r2);
            r.Add(a1);
            r.Add(a2);

            Rooms biggestRoom=r2;
            Apartment smallestApartment=a1;

            for (int i = 0; i < r.Count; i++)
            {
                if(r[i] is Rooms)
                {
                    if (r[i].Area > biggestRoom.Area)
                    {
                        biggestRoom.Area = r[i].Area;

                    }
                    
                }
                else
                {
                    if (r[i].Area < smallestApartment.Area)
                    {
                        smallestApartment.Area = r[i].Area;
                    }
                }
            }

            Console.WriteLine("Smallest apartment area: "+smallestApartment.Area);
            Console.WriteLine("Biggest room area: "+biggestRoom.Area);

            if (smallestApartment.Area > biggestRoom.Area)
            {
                Console.WriteLine("Smallest apartment has bigger area than biggest room. Difference: "+(smallestApartment.Area-biggestRoom.Area));
            }
            else
            {
                Console.WriteLine("Biggest room has bigger area than smallest apartment. Difference: " + Math.Abs(biggestRoom.Area - smallestApartment.Area));
            }
        }
    }
}
