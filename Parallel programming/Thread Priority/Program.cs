using System.Diagnostics;

static void countToMillion()
{
    for(int i = 0; i < 1000000; i++)
    {

    }
}

Thread t1 = new Thread(countToMillion);
t1.Priority = ThreadPriority.Lowest;
Stopwatch sw = Stopwatch.StartNew();
sw.Start();
t1.Start();
t1.Join();
sw.Stop();
Console.WriteLine("First thread with lowest priority: " + sw.ElapsedMilliseconds);

Thread t2 = new Thread(countToMillion);
t2.Priority = ThreadPriority.Normal;
sw.Restart();
t2.Start();
t2.Join();
sw.Stop();
Console.WriteLine("Second thread with normal priority: " + sw.ElapsedMilliseconds);

Thread t3 = new Thread(countToMillion);
t3.Priority = ThreadPriority.Highest;
sw.Restart();
t3.Start();
t3.Join();
sw.Stop();
Console.WriteLine("Third thread with highest priority: " + sw.ElapsedMilliseconds);
