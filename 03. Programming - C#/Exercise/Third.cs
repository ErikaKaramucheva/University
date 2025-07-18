using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Third
    {
        public static void ExThree()
        {
            /*Console.WriteLine("Въведете оценка: ");

          double grade = Double.Parse(Console.ReadLine());
          if (grade >= 5.5)
          {
              Console.WriteLine("Отличен!");
          }*/
            /* Console.WriteLine("Въведете първото число:");
             int num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете второто число: ");
             int num2 = int.Parse(Console.ReadLine());
             if (num1 > num2)
             {
                 Console.WriteLine("Първото число, {0} е по- голямо от второто- {1}", num1, num2);
             }else if (num2 > num1)
             {
                 Console.WriteLine("Второто число, {1} е по- голямо от първото- {0}", num1, num2);
             }
             else
             {
                 Console.WriteLine("Двете числа са равни- " + num1);
             }*/
            /*Console.WriteLine("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Четно");

            }
            else
            {
                Console.WriteLine("Нечетно");
            }*/
            /*Console.WriteLine("Въведете вашата парола: ");
            string password = Console.ReadLine();
            if (password.Equals("s3cr3t!P@ssw0rd"))
            {
                Console.WriteLine("Добре дошли!");
            }
            else
            {
                Console.WriteLine("Грешна парола!");
            }*/
            /* Console.WriteLine("Въведете число: ");
             int number = int.Parse(Console.ReadLine());
             if (number < 100)
             {
                 Console.WriteLine("Числото е по- малко от 100");
             }else if(number>=100 && number <= 200)
             {
                 Console.WriteLine("Числото е между 100 и 200");
             }
             else
             {
                 Console.WriteLine("Числото е по- голямо от 200");
             }*/
            /* Console.WriteLine("Въведете скорост:");
             double speed = Double.Parse(Console.ReadLine());
             if (speed <= 10)
             {
                 Console.WriteLine("slow");
             }else if(speed>10 && speed <= 50)
             {
                 Console.WriteLine("average");

             }else if(speed>50 && speed <= 150)
             {
                 Console.WriteLine("fast");
             }else if(speed>150 && speed <= 1000)
             {
                 Console.WriteLine("ultra fast");
             }
             else
             {
                 Console.WriteLine("extremely fast");
             }*/
            Console.WriteLine("Enter figure type: ");
            string type = Console.ReadLine();
            if (type.Equals("square"))
            {
                double side = Double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine("Лицето на квадрата е:" + Math.Round(area, 3));

            }
            else if (type.Equals("rectangle"))
            {
                double sideA = Double.Parse(Console.ReadLine());
                double sideB = Double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine("Лицето на правоъгълника е:" + Math.Round(area, 3));
            }
            else if (type.Equals("circle"))
            {
                double radius = Double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine("Лицето на кръга е:" + Math.Round(area, 3));
            }
            else if (type.Equals("triangle"))
            {
                double side = Double.Parse(Console.ReadLine());
                double h = Double.Parse(Console.ReadLine());
                double area = side * h / 2;
                Console.WriteLine("Лицето на триъгълника е:" + Math.Round(area, 3));
            }
            else
            {
                Console.WriteLine("Wrong figure! Please check between square, rectangle,circle and triangle");
            }

        }
    }
}
