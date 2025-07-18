using System;

namespace ShapeAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("triangle", 3, 2, 4, 5);
            Circle c1 = new Circle("Circle ", 0, 3);
            Rectangle r1 = new Rectangle("rectangle", 4, 2, 5);

            Console.WriteLine("T1 area="+Math.Round(t1.calculateArea(),5));
            Console.WriteLine("C1 area= "+c1.calculateArea());
            Console.WriteLine("r1 area="+r1.calculateArea());
            Console.WriteLine("t1 perimeter= "+t1.calculatePerimeter());
            Console.WriteLine("c1 perimeter+ "+c1.calculatePerimeter());
            Console.WriteLine("r1 perimeter= "+r1.calculatePerimeter());
        }
    }
}
