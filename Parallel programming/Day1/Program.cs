internal class Program
{
    public static void printCurrentTime()
    {
        Console.WriteLine(DateTime.Now);
    }
    public static void Main(string[] args)
    {
        Thread t1 = new Thread(printCurrentTime);
        t1.Start();
        Console.WriteLine("End of my console app");
    }
}