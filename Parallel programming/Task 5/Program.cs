using System.Diagnostics;
using System.Numerics;

public class Program
{

    public static int[] numbers = new int[1000000];

    public static void generateNumbers()
    {
        Random random = new Random();
        for (int i = 0; i < 1000000; i++)
        {
            numbers[i] = random.Next(1, 10);
        }
    }

    public static int sumNumbers()
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    public static int simdMethod()
    {
        int sum = 0;
        int vectorSize = Vector<int>.Count;
        Vector<int> result = new Vector<int>();
        for (int i = 0; i <= numbers.Length - vectorSize; i += vectorSize)
        {
            Vector<int> vector = new Vector<int>(numbers, i);
            result = result + vector;
        }
        sum = Vector.Sum(result);
        return sum;
    }

    public static int result = 0;
    public static void calculate(object number)
    {
        int currentResult = 0;
        int n = int.Parse(number.ToString());
        for (int i = n; i < (n + 200000); i++)
        {
            currentResult += numbers[i];
        }
        result += currentResult;
    }

    public static int sumWithThreads()
    {
        Thread[] threads = new Thread[5];
        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(calculate);
            threads[i].Start(index);
            index += 200000;
        }
        foreach (Thread t in threads)
        {
            t.Join();
        }
        return result;

    }

    public static void Main(string[] args)
    {
        generateNumbers();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        sumWithThreads();
        sw.Stop();
        Console.WriteLine("With threads: " + sw.ElapsedMilliseconds);

        sw.Restart();
        simdMethod();
        sw.Stop();
        Console.WriteLine("With simdMethod: " + sw.ElapsedMilliseconds);
        sw.Restart();
        sumNumbers();
        sw.Stop();
        Console.WriteLine("With linear: " + sw.ElapsedMilliseconds);

    }




}
