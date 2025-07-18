using System;

namespace TestPreparation5Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle("rectangle", 5, 4);
            Rectangle r2 = new Rectangle("rectangle", 3, 2);

            Triangle t1 = new Triangle("triangle", 4, 2, 1.5, 7);
            Triangle t2 = new Triangle("triangle", 3, 5, 2, 3.3);

            Circle c1 = new Circle("circle", 3);
            Circle c2 = new Circle("circle", 2.8);

            Square s1 = new Square("square", 4);
            Square s2 = new Square("square", 2.6);

            double r1Area = r1.calculateArea();
            double r1Perimeter = r1.calculatePerimeter();

            Console.WriteLine(r1Area);
            Console.WriteLine(r1Perimeter);

        }
    }
}
