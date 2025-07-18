using System.Runtime.CompilerServices;

internal class Program
{

    static int[] threadResult = new int[5];
    static void GenerateRandomNumber(object i)
    {
        Random random = new Random();
        int number = int.Parse(i.ToString());
        int current = random.Next(1, 500);
        threadResult[number] = current;
        Console.WriteLine(current);
    }

    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread thread1 = new Thread(GenerateRandomNumber);
            thread1.Start(i);
            thread1.Join();
        }

        int result = 0;
        for (int i = 0; i < threadResult.Length; i++)
        {
            result += threadResult[i];
        }

        Console.WriteLine(result);

    }
}