using System;
using System.Collections.Generic;
using System.Text;

namespace SecondHomeworkADS
{
    class Third
    {
        List<int> testList = new List<int> { 3, 5, 3, 7, 2, 8, 4, 4, 3, 4, 5, 7, 9, 6, 4, 4 };
        //FindLargestSequenceOfNumbers(testList);

        public static void FindLargestSequenceOfNumbers(List<int> testList)
        {
            int number = 0;
            int count = 0;

            for (int i = 0; i < testList.Count; i++)
            {
                int tempNumber = testList[i];
                int tempCount = 0;
                for (int j = 0; j < testList.Count; j++)
                {
                    if (testList[j] == tempNumber)
                    {
                        tempCount++;
                    }
                }

                if (tempCount > count)
                {
                    number = tempNumber;
                    count = tempCount;
                }
            }




            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(number);
            }
        }
    }
}
