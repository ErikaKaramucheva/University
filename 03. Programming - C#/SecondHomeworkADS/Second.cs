using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SecondHomeworkADS
{
    class Second
    {
        
           /* static void Main(string[] args)
            {
                List<int> testList = new List<int> { -3, 5, 3, -7, 2, -8, 4, -4, 3, 4, -5, 7, -9, 6, 4, -4 };
                RemoveNegativeNumbers(testList);
                Console.WriteLine();
                RemoveNegativeNumbersWithLinq(testList);

            }*/

            public static void RemoveNegativeNumbers(List<int> testList)
            {

                for (int i = 0; i < testList.Count; i++)
                {
                    if (testList[i] < 0)
                    {
                        testList.Remove(testList[i]);
                    }
                }

                for (int i = 0; i < testList.Count; i++)
                {
                    Console.WriteLine(testList[i]);
                }
            }

            public static void RemoveNegativeNumbersWithLinq(List<int> testList)
            {
                var newList = testList.Where(x => x >= 0);
                foreach (var test in newList)
                {
                    Console.WriteLine(test); ;
                }
            }
        
    }
}
