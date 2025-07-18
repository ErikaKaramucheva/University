using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enetr an integer between 1 and 20: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    while(matrix[i,j]<1|| matrix[i, j]>20)
                    {
                        Console.WriteLine("The number must be between 1 and 20.");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }

            if (isMagic(matrix,size) == false)
            {
                Console.WriteLine("This is not a magic square.");
            }
            else
            {
                Console.WriteLine("This is a magic square.");
            }
     

        }

        public static bool isMagic(int[,] matrix, int size)
        {

            int sumd1 = 0;
            int sumd2 = 0;

            for (int i = 0; i < size; i++)
            {
             
                sumd1 = sumd1 + matrix[i, i];
                sumd2 = sumd2 + matrix[i, size - 1 - i];
            }
            if (sumd1 != sumd2)
                return false;

            for (int i = 0; i < size; i++)
            {

                int rowSum = 0, colSum = 0;
                for (int j = 0; j < size; j++)
                {
                    rowSum += matrix[i, j];
                    colSum += matrix[j, i];
                }
                if (rowSum != colSum || colSum != sumd1)
                    return false;
            }

            return true;
        }

    
    }

}  

