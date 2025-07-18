static void printNumber(object number)
{
    Console.WriteLine(number.ToString());
}
//1 option
//for (int i = 1; i <= 5; i++)
//{
//    Thread t1 = new Thread(printNumber);
//    t1.Start(i);
//    t1.Join();
//}
//Console.WriteLine("End of my console app");

//2 option
Thread[] threads = new Thread[5];
for(int i = 1; i < 6; i++)
{
    Thread currentThread = new Thread(printNumber);
    threads[i-1] = currentThread;
    currentThread.Start(i);
}
foreach(Thread thread in threads)
{
    thread.Join();
}
Console.WriteLine("End of my console app");
