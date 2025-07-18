using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class First
    {
        public void ProgrammingBasics()
        {
            /*   Console.WriteLine("Hello World!");
                   Console.WriteLine("Hello,SoftUni");
                   Console.WriteLine(1);
                   Console.WriteLine(2);
                   Console.WriteLine(3);
                   Console.WriteLine(4);
                   Console.WriteLine(5);
                   Console.WriteLine(6);
                   Console.WriteLine(7);
                   Console.WriteLine(8);
                   Console.WriteLine(9);
                   Console.WriteLine(10);
                   for(int i = 1; i <= 10; i++)
                   {
                       Console.WriteLine(i);
                   }
                   Console.WriteLine("Enter a value for A side");
                   double a = Double.Parse(Console.ReadLine());
                   Console.WriteLine("Enter a value for B side");
                   double b=Double.Parse(Console.ReadLine());
                   Console.WriteLine("Aarea= " + a * b);*/
            /* Console.WriteLine("Enter inches for converting:");
             double inches = Double.Parse(Console.ReadLine());
             Console.WriteLine(inches + " inches are equal to " + inches * 2.54 + "cm.");*/
            /* Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();
             Console.WriteLine("Hello, " + name + "!");*/
            //име, фамилия, възраст и град и печата следното съобщение: "You are <firstName> <lastName>, a <age>-years old person from <town>."
            /*  Console.WriteLine("Enter your first name:");
              string firstName = Console.ReadLine();
              Console.WriteLine("Enter your last name:");
              string lastName = Console.ReadLine();
              Console.WriteLine("Enter your town name:");
              string town = Console.ReadLine();
              Console.WriteLine("Enter your age: ");
              int age = int.Parse(Console.ReadLine());
              Console.WriteLine("You are " + firstName + " " + lastName + ", a  " + age + "-years old person from " + town + ".");*/
            //7
            /*Console.WriteLine("Въведете името на архитекта: ");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете броя проекти, които трябва да се изготвят: ");
            int projectCount = int.Parse(Console.ReadLine());
            int hours = projectCount * 3;
            Console.WriteLine("The architect {0}  will need {1} hours to complete {2} project ",name,hours,projectCount);
            */
            /* Console.WriteLine("Въведете броя на храната за кучета: ");
             int dogsFood = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете броя на храната за кучета: ");
             int catsFood = int.Parse(Console.ReadLine());
             double price = (dogsFood * 2.5) + (catsFood * 4);
             Console.WriteLine(price + " lv.");*/
            Console.WriteLine("Въведете кв. метри, които трябва да бъдат озеленени: ");
            double meters = Double.Parse(Console.ReadLine());
            double priceBeforeDiscount = meters * 7.61;
            double discount = priceBeforeDiscount * 0.18;
            double priceAfterDiscount = priceBeforeDiscount - discount;
            Console.WriteLine("The final price is: {0} lv.", priceAfterDiscount);
            Console.WriteLine("The discount is: {0} lv.", discount);
        }
    }
}
