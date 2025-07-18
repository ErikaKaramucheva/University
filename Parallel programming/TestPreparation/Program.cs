using System.Diagnostics;
using System.Numerics;
using System.Security;

public class Program
{
    public static Semaphore semaphore;
    public static Random random = new Random();
    public static double revenue = 0;
    public static object lockObj=new object();
    public static bool isOpen = true;

    public static void GetDrink(int studentId)
    {
        string drink = "";
        double price = 0;
        int choice=random.Next(1,4);
        if (choice == 1)
        {
            drink = "Beer";
            price = 2.5;
        }
        else if (choice == 2)
        {
            drink = "Whiskey";
            price = 3.75;
        }else
        {
            drink = "Cola";
            price = 2;
        }
        Console.WriteLine($"Student {studentId} get {drink}.");
        lock (lockObj)
        {
            revenue += price;
        }
    }
    
    public static void Student(object id)
    {
        if (!isOpen)
        {
            return;
        }

        semaphore.WaitOne();
        Console.WriteLine("Student " + id + " entered the bar.");
        GetDrink((int)id);
        int action;
        while (isOpen)
        {
            Thread.Sleep(2000);
            action = random.Next(1, 4);
            if (action == 1)
            {
                GetDrink((int)id);
            }
            else if (action == 2)
            {
                Console.WriteLine(id + " is chillling.");
            }
            else
            {
                Console.WriteLine(id + " left the bar.");
                break;
            }
        }
        semaphore.Release();
    }
    public static void Main(string[] args)
    {
        semaphore = new Semaphore(20,20);
        List<Thread> students = new List<Thread>();
        int studentsCount = random.Next(20, 51);
        Console.WriteLine(studentsCount+" students wanted to go to the bar.");
        for (int i = 0; i < studentsCount; i++)
        {
            Thread t = new Thread(Student);
            t.Start(i + 1);
            students.Add(t);
        }
        Thread.Sleep(100000);
        isOpen = false;

        //while (true)
        //{
        //    if (semaphore.CurrentCount == capacity)
        //    {
        //        Console.WriteLine("The bar is empty.Lights out.");
        //        break;
        //    }
        //    Thread.Sleep(1000);
        //}
        foreach(var s in students)
        {
            s.Join();
        }
        Console.WriteLine("The bar is empty.Lights out.");
        Console.WriteLine("Total revenue: "+revenue);
    }
   
}
