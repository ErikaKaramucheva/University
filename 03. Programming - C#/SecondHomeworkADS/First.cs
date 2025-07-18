using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondHomeworkADS
{
    class First
    {
        List<int> firstList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> secondList = new List<int> { 3, 2, 4, 5 };

        /*IEnumerable<int> newList = ListUnion(firstList, secondList);
            foreach (int n in newList)
             {
               Console.WriteLine(n); 
            }
    Console.WriteLine();
            ListUnion2(firstList, secondList);
    Console.WriteLine();
            ListIntersection(firstList, secondList);
    Console.WriteLine();
            ListIntersection2(firstList, secondList);*/
    

    public static IEnumerable<int> ListUnion(List<int> a, List<int> b)
    {
        var t = Enumerable.Union(a, b);
        return t;
    }

    public static void ListUnion2(List<int> a, List<int> b)
    {

        for (int i = 0; i < b.Count; i++)
        {
            if (a.Contains(b[i]))
            {
                continue;
            }
            else
            {
                a.Add(b[i]);
            }

        }
        for (int i = 0; i < a.Count; i++)
        {
            Console.WriteLine(a[i]);

        }
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

            if (b.Count > a.Count)
            {
                List<int> temp = a;
                a = b;
                b = temp;
            }
        for (int i = 0; i < a.Count - 1; i++)
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
