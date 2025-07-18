using System.Diagnostics;

public class Program
{

    public static Semaphore semaphore;
    public static int revenue = 0;
    public static int totalCars = 0;
    public static object lockObj = new object();
    public static Random random = new Random();
    public static int currentCars = 0;
    public static bool isOpen = true;

    public static void Car(object id)
    {
        Stopwatch waitingSw =new Stopwatch();
        waitingSw.Start();
        // Опит за влизане в залата
        while (waitingSw.ElapsedMilliseconds < 7000)
        {
            if (!isOpen)
            {
                semaphore.Release();
                return;
            }
            if (currentCars < 5)
            {

                lock (lockObj)
                {

                    semaphore.WaitOne();
                    currentCars++;
                    totalCars++;
                }
                Console.WriteLine($"Кола {id} влезна в автомивката.");
                int choice = random.Next(1, 4);
                string option = "";
                int price = 0;
                int time = 0;
                switch (choice)
                {
                    case 1:
                        option = "Базово измиване";
                        price = 10;
                        time = 5;
                        break;
                    case 2:
                        option = "Подробно измиване";
                        price = 20;
                        time = 10;
                        break;
                    case 3:
                        option = "Пълна грижа";
                        price = 30;
                        time = 15;
                        break;
                }
                Console.WriteLine($"Кола {id} избра {option}.");
                Thread.Sleep(time * 1000);
                lock (lockObj)
                {
                    revenue += price;
                    currentCars--;
                }
                Console.WriteLine($"Кола {id} приключи.");
                semaphore.Release();
                return;
            }
        }
        Console.WriteLine($"Кола {id} не успя да влезе.");
    }


    public static void Main(string[] args)
    {
        semaphore = new Semaphore(5,5);
        int carsCount = random.Next(10, 31);
        List<Thread> cars = new List<Thread>();
        for (int i = 0; i < carsCount; i++)
        {
            Thread thread = new Thread(Car);
            thread.Start(i + 1);
            cars.Add(thread);
            Thread.Sleep(random.Next(500, 750));
        }
        Thread.Sleep(90000);
        isOpen = false;
        foreach (var t in cars)
        {
            t.Join();
        }
        Console.WriteLine("Автомивката вече не приема автомобили.  " );
        Console.WriteLine($"Общ оборот: {revenue}. Обслужени коли: {totalCars}." );
    }

}
