static void printCurrentTime()
{
    Console.WriteLine(DateTime.Now);
}

Thread firstThread = new Thread(printCurrentTime);
firstThread.Start();
Console.WriteLine("End of my console app.");