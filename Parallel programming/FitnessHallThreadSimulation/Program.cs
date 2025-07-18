using System.Diagnostics;

public class Program
{

    public static Semaphore semaphore;
    public static object lockObj = new object();
    public static Random random = new Random();
    public static int totalTrainees = 0;
    public static int currentTrainees = 0;
    public static bool isOpen = true;

    //public static void Trainee(object id)
    //{
    //    Stopwatch waitingTimer = Stopwatch.StartNew();

    //    // Опит за влизане в залата
    //    while (waitingTimer.ElapsedMilliseconds < 5000)
    //    {
    //        if (semaphore.WaitOne(500)) // Чака 500 мс за свободно място
    //        {
    //            lock (lockObj)
    //            {
    //                if (!isOpen)
    //                {
    //                    semaphore.Release();
    //                    return;
    //                }
    //                currentTrainees++;
    //                totalTrainees++;
    //            }

    //            Console.WriteLine($"Посетител {id} влезна в залата.");
    //            int trainTime = random.Next(5, 16) * 1000;
    //            Stopwatch trainingTimer = Stopwatch.StartNew();

    //            while (trainingTimer.ElapsedMilliseconds < trainTime)
    //            {
    //                int action = random.Next(1, 5);
    //                switch (action)
    //                {
    //                    case 1:
    //                        Console.WriteLine($"Посетител {id} вдига тежести.");
    //                        break;
    //                    case 2:
    //                        Console.WriteLine($"Посетител {id} бяга на пътеката.");
    //                        break;
    //                    case 3:
    //                        Console.WriteLine($"Посетител {id} прави лицеви опори.");
    //                        break;
    //                    default:
    //                        Console.WriteLine($"Посетител {id} почива.");
    //                        break;
    //                }
    //                Thread.Sleep(2000);
    //            }

    //            Console.WriteLine($"Посетител {id} излезна от залата.");
    //            lock (lockObj)
    //            {
    //                currentTrainees--;
    //            }
    //            semaphore.Release();
    //            return;
    //        }
    //    }

    //    Console.WriteLine($"Посетител {id} се отказа, защото чакаше твърде дълго.");
    //}
    
    public static void Trainee(object id)
    {
        if (!isOpen) return;
        if (!semaphore.WaitOne(5000))
        {
            Console.WriteLine($" posetitel {id} ne uspq da vleze.");
            return;
        }
        lock (lockObj)
        {
           
            if (!isOpen)
            {
                semaphore.Release();
                return;
            }
            totalTrainees++;
        }
        Console.WriteLine($"Posetitel {id} e v zalata.");
        int time = random.Next(5, 16);
        Stopwatch sw = Stopwatch.StartNew();
        int action;
        while (sw.ElapsedMilliseconds < time * 1000)
        {
            action = random.Next(4);
            switch (action)
            {
                case 0: Console.WriteLine($"Posetitel {id} vdiga tejesti."); break;
                case 1: Console.WriteLine($"Posetitel {id} bqga na patekata."); break;
                case 2: Console.WriteLine($"Posetitel {id} pravi nlicevi opori."); break;
                default: Console.WriteLine($"Posetitel {id} si pochiva."); break;
            }
            Thread.Sleep(2000);
        }
            Console.WriteLine($"Posetitel {id} izleze ot zalata.");
            semaphore.Release();
        }
    

public static void Main(string[] args)
    {
        semaphore = new Semaphore(10, 10);
        int traineesCount = random.Next(5, 31);
        List<Thread> trainees = new List<Thread>();
        for (int i = 0; i < traineesCount; i++)
        {
            Thread thread = new Thread(Trainee);
            thread.Start(i + 1);
            trainees.Add(thread);
            Thread.Sleep(random.Next(100, 500));
        }
        Thread.Sleep(60000);
        isOpen = false;
        foreach (var t in trainees)
        {
            t.Join();
        }
        Console.WriteLine("Залата затвори. Успешно тренирали: " + totalTrainees);
    }

}
