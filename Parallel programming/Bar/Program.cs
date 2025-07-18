class Bar
{
    private static int capacity = 20;
    private static SemaphoreSlim semaphore = new SemaphoreSlim(capacity, capacity);
    private static object lockObj = new object();
    private static Random random = new Random();
    private static decimal revenue = 0;
    private static bool isOpen = true;
    private static List<string> drinks = new List<string> { "Beer", "Whiskey", "Vodka", "Cocktail", "Juice" };

    public static void Student(int id)
    {
        if (!isOpen) return;

        semaphore.Wait();
        Console.WriteLine($"Student {id} entered the bar.");

        while (isOpen)
        {
            Thread.Sleep(2000);
            int action = random.Next(3);

            if (action == 0) // Order drink
            {
                string drink = drinks[random.Next(drinks.Count)];
                decimal price = random.Next(5, 16);
                lock (lockObj)
                {
                    revenue += price;
                }
                Console.WriteLine($"Student {id} ordered {drink} for ${price}.");
            }
            else if (action == 1) // Do nothing
            {
                Console.WriteLine($"Student {id} is chilling.");
            }
            else // Leave
            {
                Console.WriteLine($"Student {id} left the bar.");
                break;
            }
        }

        semaphore.Release();
    }

    public static void Main()
    {
        List<Thread> students = new List<Thread>();
        int studentCount = new Random().Next(2, 21);
        Console.WriteLine($"{studentCount} students want to go to the bar.");

        for (int i = 0; i < studentCount; i++)
        {
            Thread studentThread = new Thread(() => Student(i + 1));
            students.Add(studentThread);
            studentThread.Start();
            Thread.Sleep(random.Next(500, 2000)); // Random entry time
        }

        Thread.Sleep(100000); // Bar operates for 120 seconds
        isOpen = false;

        while (true)
        {
            if (semaphore.CurrentCount == capacity)
            {
                Console.WriteLine("The bar is empty. Lights out.");
                break;
            }
            Thread.Sleep(1000);
        }

        foreach (var student in students)
        {
            student.Join();
        }

        Console.WriteLine($"Total revenue: ${revenue}");
    }
}