using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondHomeworkADS
{
    class Program
    {
        static void Main(string[] args)
        {
             DoublyLinkedList list = new DoublyLinkedList();

             list.Add(1);
            list.Add(4);
             list.Add(1);
             list.Add(12);
             list.Add(1);
             list.PushAt(5, 6);
             list.RemoveFirst();

             Console.WriteLine("Element at index 3 is "
                               + list.GetElementByIndex(3));
             list.Print();
            Console.WriteLine();
            Console.WriteLine(list.FindElement(12
                ));

            List<int> a = new List<int> { 2, 5, 7, 8, 11 };
            List<int> b = new List<int> { 2,4,9,14, 5, 7, 8, 11 };
           // ListIntersection2(a, b);
            //ListIntersection(a, b);

        }
        public static void ListIntersection(List<int> a, List<int> b)
        {
            IEnumerable<int> newList = a.Intersect(b);
            foreach (var t in newList)
            {
                Console.WriteLine(t);
            }
        }

        public static void ListIntersection2(List<int> a, List<int> b)
        {
            List<int> newList = new List<int>();

            if (a.Count > b.Count)
            {
                List<int> temp = b;
                b = a;
                a = temp;
            }
            for (int i = 0; i < b.Count ; i++)
            {
                if (a.Contains(b[i]))
                {
                    newList.Add(b[i]);
                }
            }

            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);

            }
        }


        }
}
