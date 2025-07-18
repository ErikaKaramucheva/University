public class Program {

    public static double balance = 1000;

    public static void deposit(object money)
    {
        double currentSum = double.Parse(money.ToString());
        balance += currentSum;
        Console.WriteLine("Deposit: "+ currentSum);
    }

    public static void withdraw(object money)
    {
        double currentSum = double.Parse(money.ToString());
        balance -= currentSum;
        Console.WriteLine("Withdraw: " + currentSum);
    }

    public static void Main(string[] args)
    {
        Thread[] threads = new Thread[10];
        Random random = new Random();
        for(int i=0; i<threads.Length; i++)
        {
            Thread thread;
            if (i % 2 == 0)
            {
                thread = new Thread(deposit);
            }
            else
            {
                thread = new Thread(withdraw);
            }
            thread.Start(random.Next(1, 100));
            threads[i] = thread;
        }

        foreach(Thread t in threads)
        {
            t.Join();
        }

        Console.WriteLine("Balance: " + balance);
    }

}
