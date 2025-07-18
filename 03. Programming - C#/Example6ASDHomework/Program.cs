using System;

namespace Example6ASDHomework
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter a number between 10 and 10010: ");
            int number = int.Parse(Console.ReadLine());
            int sum = returnSum(number);
            Console.WriteLine(sum);
        }

        public static int returnSum(int number)
        {
            if (number < 10)
            {
                return number;
            }
            int sum = number % 10;
            number /=10;
            return sum+returnSum(number);
        }
    }
}
