using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array: ");
            int size = int.Parse(Console.ReadLine());

             int[] arr = generateArrayWithRandomNumbers(size);
             returnTheMostCommonNumber(arr);
        }

        public static int[] generateArrayWithRandomNumbers(int size)
           {
               int[] arr = new int[size];
               Random rand = new Random();

               Console.WriteLine("We generated an array: ");
               for (int i = 0; i < arr.Length; i++)
               {
                   arr[i] = rand.Next(10, 99);
                   Console.WriteLine(arr[i]) ;
               }
               return arr;
    }

        public static void returnTheMostCommonNumber(int[] arr)
        {
            int tempNumber=arr[0];
            int frequentNumber=arr[0];
            int countOfMostCommonNumber = 0;
         
            for (int i = 0; i < arr.Length; i++)
            {
                
                int countOfCurrentElement = 0;
                for (int j = 0; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        tempNumber = arr[i];
                        countOfCurrentElement++;
                    }
                }
                if (countOfCurrentElement > countOfMostCommonNumber)
                {
                    countOfMostCommonNumber = countOfCurrentElement;
                    frequentNumber=tempNumber;
                }
            }
            if (countOfMostCommonNumber == 1|| countOfMostCommonNumber==0)
            {
                Console.WriteLine("We didn't find same numbers in this array.");
            }
            else
            {
                Console.WriteLine("The most common number in this array is: " + frequentNumber);
                Console.WriteLine("We found it " + countOfMostCommonNumber + " times.");
            }
        }
    }
}

   
