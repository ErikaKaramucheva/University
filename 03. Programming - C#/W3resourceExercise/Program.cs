using System;

namespace W3resourceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to print Hello and your name in a separate line.
            // Expected Output :Hello: Alexandra Abramov
            // Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello: " + name);
            //2.Write a C# Sharp program to print the sum of two numbers.
            /* Console.WriteLine("Enter two numbers: ");
             double num1 = Double.Parse(Console.ReadLine());
             double num2 = Double.Parse(Console.ReadLine());
             Console.WriteLine("Sum: " + (num1 + num2));*/

            //3.Write a C# Sharp program to print the result of dividing two numbers.
            /*Console.WriteLine("Enter two number:");
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Result of dividing: " + (num1 / num2));*/

            //4.Write a C# Sharp program to print the results of the specified operations.
            //Test data:
            //-1 + 4 * 6
            //(35 + 5) % 7
            //14 + -4 * 6 / 11
            //2 + 15 / 6 * 1 - 7 % 2
            //Expected Output:
            //23
            //5
            //12
            //3
            /*Console.WriteLine("-1+4*6=" + (-1 + 4 * 6));
            Console.WriteLine("(35+5)%7=" + ((35 + 5) % 7));
            Console.WriteLine("14+-4*6/11=" + (14 + -4 * 6 / 11));
            Console.WriteLine("2+15/6*1-7%2=" + (2 + 15 / 6 * 1 - 7 % 2));*/
            /*5.Write a C# Sharp program to swap two numbers.
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output:
            After Swapping :
            First Number : 6
            Second Number : 5*/
            Console.WriteLine("Enter two numbers for swapping:");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;
            Console.WriteLine("After swapping:\n First number: " + numberOne);
            Console.WriteLine("Second number: " + numberTwo);
            Console.WriteLine("Hello World!");
        }
    }
}
