using System;
using System.Collections.Generic;

namespace TestPreparation4Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("Triangle", 3, "triangle", 2.4, 3.7, 1, 2.7);
            Triangle t2 = new Triangle("Triangle", 3, "triangle", 1, 3, 4, 5);

            Circle c1 = new Circle("circle", 0, "circle", 3);
            Circle c2 = new Circle("circle", 0, "circle", 4.5);

            Rectangle r1 = new Rectangle("rectangle", 4, "rectangle", 2, 4);
            Rectangle r2 = new Rectangle("rectangle", 4, "rectangle", 5, 2.4);

            List<Shape> s = new List<Shape>();
            s.Add(t1);
            s.Add(t2);
            s.Add(c1);
            s.Add(c2);
            s.Add(r1);
            s.Add(r2);

            for (int i = 0; i < s.Count; i++)
            {
                if(s[i] is Circle)
                {
                    Console.WriteLine("Yes, we found circle at index "+i);
                }
            }
        }
    }
}
