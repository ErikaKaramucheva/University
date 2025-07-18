using System.Diagnostics;
using System.Numerics;

public class Program
{
    public static SemaphoreSlim semaphore = new SemaphoreSlim(20, 20);
    public static int revenue = 0;
    public static object lockObj = new object();
    public static Random random = new Random();
    public static bool isOpen = true;
    public static Queue<int> students = new Queue<int>();

    public static void GetDrink(object id)
    {
        int choice = random.Next(1, 4);
        string drink = "";
        int price = 0;
        switch (choice)
        {
            case 1: drink = "beer"; price = 2; break;
            case 2: drink = "cola"; price = 3; break;
            default: drink = "whiskey"; price = 5; break;
        }
        Console.WriteLine($"Student {id} si izbra {drink}.");
        lock (lockObj)
        {
            revenue += price;
            students.Enqueue((int)id);
        }
    }
    public static void Student(object id)
    {
        semaphore.Wait();
        if (!isOpen)
        {
            semaphore.Release();
            return;
        }
        Console.WriteLine($"Student {id} vleze v bara.");
        int action;
        while (isOpen)
        {
            action = random.Next(1, 4);
            switch (action)
            {
                case 1: GetDrink(id); break;
                case 2: Console.WriteLine($"Student {id} tancuva."); break;
                default: Console.WriteLine($"Student {id} napuska."); semaphore.Release(); return;
            }
            Thread.Sleep(2000);
        }

    }

    public static void Bartender(object id)
    {
        while (isOpen)
        {
            int currentStudentOrder = -1;
            lock (lockObj)
            {
                if (students.Count > 0)
                {
                    currentStudentOrder = students.Dequeue();
                }
            }
            if (currentStudentOrder > 0)
            {
                Console.WriteLine($"Barman {id} shte obraboti porachka {currentStudentOrder}.");
                Thread.Sleep(300);
                Console.WriteLine($"Barman {id} obraboti porachka {currentStudentOrder}");
            }
        }
    }
    public static void Main(string[] args)
    {
        Thread b1 = new Thread(Bartender);
        Thread b2 = new Thread(Bartender);
        b1.Start(1);
        b2.Start(2);
        List<Thread> threads = new List<Thread>();
        for(int i = 0; i < 50; i++)
        {
            var t = new Thread(Student);
            t.Start(i);
            threads.Add(t);
            Thread.Sleep(random.Next(500, 1000));
        }
        Thread.Sleep(10000);
        isOpen = false;
        foreach (var t in threads)
        {
            t.Join();
        }
        b1.Join();
        b2.Join();
        Console.WriteLine("Barat zatvori. oborot: " + revenue);

    }
}