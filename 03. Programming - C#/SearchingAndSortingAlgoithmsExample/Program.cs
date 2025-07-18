using System;

namespace SearchingAndSortingAlgoithmsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 8, 15, 24, 32, 11, 5, 16, 3, 29, 54, 6 };
            int number = 6;
            //LinearSearch(arr, number);
            // InsertionSort(arr);
            // BubbleSort(arr);
            //BinarySearch(arr, number);
            SelectionSort(arr);
            
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int smallest = i;
                for (int j = i+1;j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }

                int temp = arr[smallest];
                arr[smallest]=arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("Selection Sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

       /* public static void LinearSearch(int[] arr,int number)
        {
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine(i+1);
                    isFound = true;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("We didn't find this element.");
            }
        }*/

        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j>0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine("After insertion sort the array looks like: ");
            for (int i = 0; i < arr.Length;  i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] = arr[j] + arr[j + 1];
                        arr[j + 1] = arr[j] - arr[j + 1];
                        arr[j] = arr[j] - arr[j + 1];
                    }
                }

            }

            Console.WriteLine("BubbleSort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void BinarySearch(int[] arr,int number)
        {
            Console.WriteLine("Binary search:");
            int left = arr[0];
            int right = arr.Length;
            while (left<right)
            {
                int mid = (left + right) / 2;
                if (mid == number)
                {
                    Console.WriteLine("We found it.");
                    break;
                }else if (number < mid)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
        }
    }
}
