static void printNumber(object number)
{
    Console.WriteLine(number.ToString());
}

//for(int i = 1; i <= 5; i++)
//{
//    Thread thread = new Thread(printNumber);
//    thread.Start(i);
//     //thread.Join();
//    while (thread.IsAlive)
//    {

//    }

//}
Thread thread1 = new Thread(printNumber);
thread1.Start("1");
thread1.Join();

Thread thread2 = new Thread(printNumber);
thread2.Start("2");
thread2.Join();

Thread thread3 = new Thread(printNumber);
thread3.Start("3");
thread3.Join();

Thread thread4 = new Thread(printNumber);
thread4.Start("4");
thread4.Join();

Thread thread5 = new Thread(printNumber);
thread5.Start("5");
thread5.Join();

Console.WriteLine("End of my console app");