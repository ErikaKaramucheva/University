using System;

namespace ReverseNumbers
{
    class Program
    {
        public static void reverse(int num)
        {

            while (num  != 0)
            {
                int n = num % 10;
                num /= 10;
                Console.Write(n);
                
            }

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            reverse(num);
        }
    }
}
