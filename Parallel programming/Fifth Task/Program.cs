using System.Diagnostics;
using System.Numerics;

internal class Program
{
    static int[] numbers = new int[1000000];
    static void GenerateNumbers()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Random random = new Random();
            numbers[i] = random.Next(1, 10);
        }
    }

    static int sumNumbersOneByOne()
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static void simdMethod()
    {
        Vector<int> result=new Vector<int>(numbers,0);
        for (int i = 0; i < numbers.Length-4; i+=4) {
            Vector<int> vector1 = new Vector<int>(numbers,i);
            result =result + vector1;
            //result.CopyTo(numbers, i);
                }
        int sum =Vector.Sum(result);
        Console.WriteLine(sum);
    }

    static List<int> result= new List<int>();

    public static void calculateSum(object startNumber)
    {
        int sum = 0;
        int number = int.Parse(startNumber.ToString());
        for(int i = number; i < 200000; i++)
        {
            sum += numbers[number];
        }
        result.Add(sum);
        //result[currentIndex]= sum;
    }
    static void Main(string[] args)
    {
        GenerateNumbers();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.WriteLine(sumNumbersOneByOne());
        sw.Stop();
        Console.WriteLine("Time from a: " + sw.ElapsedMilliseconds);
        sw.Restart();
        simdMethod();
        sw.Stop();
        Console.WriteLine("Time from simd Method: " + sw.ElapsedMilliseconds);

        sw.Restart();
        Thread t1 = new Thread(calculateSum);
        t1.Start(0);
        t1.Join();
        Thread t2 = new Thread(calculateSum);
        t2.Start(200000);
        t2.Join();
        Thread t3 = new Thread(calculateSum);
        t3.Start(400000);
        t3.Join();
        Thread t4 = new Thread(calculateSum);
        t4.Start(600000);
        t4.Join();
        Thread t5 = new Thread(calculateSum);
        t5.Start(800000);
        t5.Join();
        sw.Stop();

        // Console.WriteLine("Sum: " + sum);
        int totalSum = 0;
       for(int i = 0; i < result.Count; i++)
        {
           // Console.WriteLine(result[i]);
            totalSum += result[i];  
        }
        Console.WriteLine("Sum: " + totalSum);
        Console.WriteLine("Time from threads: " + sw.ElapsedMilliseconds);


    }

}