using System;

namespace Algorithms
{
    class Program
    {
        public static void linearSearch(int[] arr, int number)
        {

            bool isFind = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine("We find it at " + (i + 1) + " position.");
                    isFind = true;
                }
            }
            if (isFind == false)
            {
                Console.WriteLine("We didn't find it.");
            }
        }
        public static void binarySearch(int[] arr, int number)
        {
            Array.Sort(arr);
            Console.WriteLine("Array after sorting: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
            Console.WriteLine();
            int count = 0;
            int left = arr[0];
            int right = arr.Length-1;
            for (int i = 0; i < (left+right)/2; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine("We find it at "+(i+1)+" position.");
                }else if (number<arr[i]) {
                    right = arr[i];
                    Console.WriteLine(right);
                }else if (number > arr[i])
                {
                    left = arr[i];
                    Console.WriteLine(left);
                }
                count++;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 9, 2, 5, 1, 4, 6, 3 };
            Console.WriteLine("Which number do you whant to find?");
            int number = int.Parse(Console.ReadLine());
            
            //linearSearch(arr,number);
            binarySearch(arr,number);

        }
    }
}
