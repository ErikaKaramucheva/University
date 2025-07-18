using System;
using System.Collections.Generic;

namespace ADSHomeworks
{
    class Program
    {
        public static double firstExercise(int number)
        {
            int[] numbers = new int[number];
            double sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Write a number");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            return sum;
        }
        public static void second()
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];
            for(int i = 0; i < arrLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            List<int> n = new List<int>();
            int number ;
            int size = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                number = arr[i];
                int currentSize = 1;
                List<int> current = new List<int>();
                for(int j = i + 1; j < arr.Length; j++)
                {
                    current.Add(arr[i]);
                    if (number == arr[j])
                    {
                        current.Add(number);
                        currentSize++;
                    }
                }
                if (n.Count < current.Count)
                {
                    n.Clear();
                    n.AddRange(current);
                    if (currentSize > size)
                    {
                        size = currentSize;
                    }
                    
                }
            }
            if (n.Count == 1)
            {
                Console.WriteLine("Съжалявам, не намираме еднакви числа в масива.");
            }
            else
            {
                Console.WriteLine("Най- често срещания елемент: " + n[0]);
                Console.WriteLine("Брой срещания: " + size);
            }
        }
        public static void taskSixWithRecursion(int result, int n)
        {
            if (n % 10 > 0)
            {
                taskSixWithRecursion(result += n % 10,n /= 10) ;
            }
            else
            {
                Console.WriteLine(result);
            }
        }
        public static void taskSix(int n)
        {
            int result = 0;
            while (n % 10 != 0)
            {
                result += n % 10;
                n /= 10;
            }
            Console.WriteLine(result);
        }
        public static void taskFive(int n)
        {
            for(int i = n; i < 100010; i++)
            {
                int flag =0;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(i);
                    return;
                }
               
            }
            Console.WriteLine("We didn't find prime numbers");

        }
        public static void TaskFour(List<int> a)
        {
            bool up = false;
            for (int i = 0; i < a.Count-1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    up = true;
                }
                else
                {
                    up = false;
                    break;
                }
            }
            if (up == false)
            {
                Console.WriteLine("Редицата не е монотонно нарастваща");
            }
            else
            {
                Console.WriteLine("Редицата е монотонно нарастваща");
            }
        }

        /*1. Да се създаде програма за работа с масив от реални числа, в която след въвеждане на цяло положително число N (N<20) чрез функции се реализира следното:
- въвеждане на елементите на масива, N на брой;
- намиране на сумата на първите N елементa.

2. Да се въведат в целочислен масив n на брой случайни положителни двуцифрени числа и да се намери числото, 
        което се среща най-често в масива и колко пъти се среща.

3. Една квадратна таблица от числа се нарича магически квадрат, когато е изпълнено следното условие: всички суми, получени поотделно от сбора на елементите по всеки ред/всеки стълб/всеки от двата диагонала са равни.
Да се състави програма, която въвежда естествени числа от интервала [1..20] в дадена квадратна таблица и определя дали те образуват магически квадрат.

4. Да се състави програма, чрез която се въвеждат 9 реални числа от интервала [-99.99..99.99].
Проверете дали въведената редица е монотонно нарастваща.
Пример: 1 2 3 3 е, но 1 3 2 4 не е монотонно нарастваща
Използвайте рекурсия

5. Да се състави програма, чрез която се въвежда естествено число N от интервала[10..100010].
Програмата да извежда най-близкото по-голямо просто число.
Пример: 98 Изход 101

6. Да се състави програма, чрез която се въвежда естествено число N от интервала[10..10010] и се извежда сумата на цифрите му.
Пример: 15 Изход: 6
Използвайте рекурсия.
        
        1. Напишете методи за сечение и обединение на списъци.
3. Напишете програма, която премахва всички отрицателни числа от дадена редица.
4. Реализирайте структурата двойно свързан динамичен списък – списък, чиито елементи имат указател, както към следващия така и към пред­хождащия го елемент.
        Реализирайте операциите добавяне, премахване и търсене на елемент, добавяне на елемент на определено място (индекс), извличане на елемент по индекс и метод, 
        който връща масив с елементите на списъка.
         
         */
        public static void TaskThree(List<int> a)
        {
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] < 0)
                {
                    a.Remove(a[i]);
                }
            }
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static void intersect(List<int> a, List<int>b)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (b.Contains(a[i]))
                {
                    if (!result.Contains(a[i]))
                    {
                        result.Add(a[i]);
                    }
                }
            }
           
            if (result.Count == 0)
            {
                Console.WriteLine("Няма съвпадащи елементи");
            }
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static void union(List<int>a, List<int> b)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < a.Count; i++)
            {
                for(int j = 0; j < b.Count; j++)
                {
                    if ((a[i] == b[j])&& !result.Contains(b[j]))
                    {
                        result.Add(b[j]);
                    }
                }
            }
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        //2. Напишете метод, който намира най-дългата подредица от равни числа в даден List<int>
        //и връща като резултат нов List<int> със тази подредица.
        public static void TaskTwo(List<int> a)
        {
            
            List<int> result = new List<int>();
            for(int i = 0; i < a.Count; i++)
            {
                List<int> temp = new List<int>();
                temp.Add(a[i]);
                for(int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        temp.Add(a[j]);
                    }
                }
                if (temp.Count > result.Count)
                {
                    result.Clear();
                    result.AddRange(temp);
                }
            }
            Console.WriteLine(result[0]);
            Console.WriteLine("Брой срещания: " + result.Count);
            /*for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }*/
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //1
            /* int number = Int32.Parse(Console.ReadLine());
             * while(number>20){
            number=Int32.Parse(Console.ReadLine());
             }
             double result = firstExercise(number);
             Console.WriteLine("Result= " + result);*/

            //2
            //   second();
            List<int> a = new List<int>(){ 1, 2, 11, 3, 4, 7, 5, 6 };
            List<int> b = new List<int>(){ 4, 2, 11,23,9};
            List<int> c = new List<int>(){ 4, 2, 4,7,7,7,7,4,7, 11,6,7,2,4,11,23,9};
            List<int> d = new List<int>(){- 4, 2, 4,-7,7,7,-7,4,7, -11,6,7,2,-4,11,-23,9};
            // intersect(a, b);
            // union(a, b);
            // TaskTwo(c);
            //TaskThree(d);
            // taskSix(78943612);
            //taskSixWithRecursion(0,78943612);
            //  taskFive(99);
            List<int> e = new List<int>();
            for(int i = 0; i < 9; i++)
            {
                e.Add(int.Parse(Console.ReadLine()));
            }
            TaskFour(e);
        }
    }
}
