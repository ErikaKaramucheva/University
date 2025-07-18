public class Program {

    public static int[] numbers = new int[500];

    public static void generateArray()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Random random = new Random();
            numbers[i] = random.Next(1,100000);
        }
    }
    public static int findMaxElementLinear()
    {
        int max = int.MinValue;
        for(int i=0;i< numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                { max = numbers[i];}
            }
        }
        return max;
    }
   static int numbersForOneIteration = numbers.Length / 5;

    static List<int> maxElements = new List<int>();
    public static void findMaxElement(object currentIndex)
    {
        int firstElement = int.Parse(currentIndex.ToString());
        int currentMax = int.MinValue;
        for(int i = firstElement; i < (firstElement + numbersForOneIteration); i++)
        {
            if (currentMax < numbers[i])
            {
                currentMax = numbers[i];
            }
        }
        maxElements.Add(currentMax);
    }
    public static void Main(string[] args)
    {
        generateArray();
        Console.WriteLine($"Max Element With Linear Iteration: "+findMaxElementLinear());
        Thread[] threads = new Thread[5];
        int currentIndex = 0;
        for (int i = 0; i < threads.Length; i++)
        {
            Thread thread = new Thread(findMaxElement);
            thread.Start(currentIndex);
            threads[i] = thread;
            currentIndex += numbersForOneIteration;
        }

        foreach(Thread t in threads)
        {
            t.Join();
        }
        int max = int.MinValue;
        for(int i = 0; i < maxElements.Count; i++)
        {
            if(maxElements[i] >max)
            {
                max=maxElements[i];
            }
        }
        Console.WriteLine("Max with thread: "+max);
    }


}
