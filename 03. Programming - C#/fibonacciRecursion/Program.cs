using System;

namespace fibonacciRecursion
{
    class Program
    {
        static int findFibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return findFibonacciNumber(n-1) + findFibonacciNumber(n - 2);
            }
            
            

        }
        static void Main(string[] args)
        {
            //int number=findFibonacciNumber(5);
            Console.WriteLine(findFibonacciNumber(9));
        }
    }
}
