using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static List<int> numbers = new List<int>();

    public static void generateRandomNumber()
    {
        Random random = new Random();
        numbers.Add(random.Next(1,500));
        //Console.WriteLine(numbers.Last());
    }

    public static void Main(string[] args)
    {
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            Thread currentThread = new Thread(generateRandomNumber);
            threads[i] = currentThread;
            currentThread.Start();
        }
        int sum = 0;
        foreach (Thread thread in threads) { thread.Join(); }
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine(sum);

    }

}