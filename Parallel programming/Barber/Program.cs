using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    static Queue<int> waitingRoom = new Queue<int>(); // чакалня
    static int maxSeats = 5;

    static object lockObj = new object(); // за достъп до чакалнята
    static AutoResetEvent barberSleep = new AutoResetEvent(false); // за събуждане на фризьора
    static SemaphoreSlim barberChair = new SemaphoreSlim(1, 1); // 1 стол за подстригване

    static Random random = new Random();

    public static void Barber()
    {
        while (true)
        {
            int clientId = -1;

            lock (lockObj)
            {
                if (waitingRoom.Count == 0)
                {
                    Console.WriteLine("💤 Фризьорът заспа.");
                    Monitor.Exit(lockObj); // излизаме ръчно от lock-а
                    barberSleep.WaitOne(); // чакаме да бъде събуден
                    Monitor.Enter(lockObj); // влизаме пак в lock-а след събуждане
                }

                if (waitingRoom.Count > 0)
                {
                    clientId = waitingRoom.Dequeue();
                }
            }

            if (clientId != -1)
            {
                Console.WriteLine($"✂️ Фризьорът подстригва клиент {clientId}...");
                Thread.Sleep(3000); // подстригване
                Console.WriteLine($"✅ Клиент {clientId} е подстриган.");
                barberChair.Release();
            }
        }
    }

    public static void Client(object id)
    {
        bool willWait = false;

        lock (lockObj)
        {
            if (waitingRoom.Count < maxSeats)
            {
                waitingRoom.Enqueue((int)id);
                Console.WriteLine($"👤 Клиент {id} зае място в чакалнята.");
                willWait = true;
                barberSleep.Set(); // събуждаме фризьора ако спи
            }
            else
            {
                Console.WriteLine($"🚪 Клиент {id} си тръгва – няма място.");
            }
        }

        if (willWait)
        {
            barberChair.Wait(); // чакаме да бъдем обслужени
        }
    }

    public static void Main(string[] args)
    {
        Thread barberThread = new Thread(Barber);
        barberThread.Start();

        for (int i = 0; i < 20; i++)
        {
            Thread clientThread = new Thread(Client);
            clientThread.Start(i);
            Thread.Sleep(random.Next(500, 1500)); // нов клиент на всеки 0.5 – 1.5 сек
        }

        barberThread.Join(); // по принцип фризьорът не спира – може да се махне
    }
}
