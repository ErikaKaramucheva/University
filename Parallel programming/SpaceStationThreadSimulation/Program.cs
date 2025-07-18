using System.ComponentModel.Design;

public class Program
{
    public static Semaphore semaphore;
    public static object lockObj=new object();
    public static Random random = new Random();
    public static int totalShips = 0;
    public static int fuel = 0;
    public static bool isOpen = true;

    public static void Ship(object id)
    {
        if (!isOpen) return;
        if (!semaphore.WaitOne(10000))
        {
            Console.WriteLine($"SHIP {id} NOT ENETERD.");
            return;
        }
        lock (lockObj)
        {
            if (!isOpen) { semaphore.Release(); return; }
            totalShips++;
        }
        Console.WriteLine($"Ship {id} is here.");
        string activity = "";
        int time = 0;
        int choice = random.Next(1, 4);
        if(choice==1) {
            activity = "fast charging";
            time = 5;
            lock (lockObj) {
                fuel += 50;
            }
        }
        else if(choice==2)
        {
            activity = "standard maintenance";
            time = 10;
        }
        else{
            activity = "full change";
            time = 20;
            lock (lockObj)
            {
                fuel += 50;
            }
        }
        Console.WriteLine($"Ship {id} choose {activity}.");

        Thread.Sleep(time * 1000);
        Console.WriteLine($"SHIP {id} IS READY TO GO.");
        semaphore.Release();

    }

    public static void Main(string[] args)
    {
        semaphore = new Semaphore(4, 4);
        int shipsCount = random.Next(10, 26);
        List<Thread> ships= new List<Thread>();
        for (int i = 0; i < shipsCount; i++)
        {
            Thread thread = new Thread(Ship);
            thread.Start(i + 1);
            ships.Add(thread);
            Thread.Sleep(random.Next(100,500));
        }
        Thread.Sleep(120000);
        isOpen=false;
        foreach (var t in ships)
        {
            t.Join();
        }
        Console.WriteLine("Closed.");
        Console.WriteLine($"Ships count: {totalShips}. Fuel: {fuel}");
    }
}