using System;
using System.Collections.Generic;

namespace HomeworkADS
{
    class Program
    {
        static void Main(string[] args)
        {
            int facultyNumber = 2101321067;
            string c = null;
            while (facultyNumber > 0)
            {

                c += facultyNumber % 2;
                facultyNumber /= 2;

            }
            Console.WriteLine("Faculty number as binary number:");
            Console.Write(c);
            Console.WriteLine();
            char[] reverseNumbers = c.ToCharArray();
            for (int i = 0; i < reverseNumbers.Length/2; i++)
            {
                int size=reverseNumbers.Length;
                char temp = reverseNumbers[i];
                reverseNumbers[i] = reverseNumbers[size - i-1];
                reverseNumbers[size - i-1] =temp;
            }
            Console.WriteLine("Faculty number as binary number after reverse:");
            Console.WriteLine(reverseNumbers);
            decimal result = Convert.ToDecimal(reverseNumbers);
           // decimal result = (decimal)reverseNumbers;
            Console.WriteLine(Math.Round(result,7));
            Console.WriteLine();
            

            
        }

        public static void FacultyNumberToBinaryCode()
        {
            int facultyNumber = 2101321067;
            List<decimal>
               resc = new List<decimal>();
            
            while (facultyNumber > 0)
            {

                resc.Add(facultyNumber % 2);
                facultyNumber /= 2;

            }
            
            resc.Reverse();
            for (int j = 0; j < resc.Count; j++)
            {
                Console.Write(resc[j]);
            }

            //Cannot convert generic collection to decimal
            var t = Convert.ToDecimal(resc);
            Console.WriteLine(Math.Round(t, 7));
        }
    }
}
