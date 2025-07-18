namespace DTasksErrors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> faultyTask = Task.Run(
                () =>
                {
                    throw new Exception("My task crashed.");
                    return 42;
                });
            Console.WriteLine("Doing something (while the task has crashed in the meanwhile)");
            Thread.Sleep(2000);

            Console.WriteLine("Now let's see what's with the task.");
            try
            {
                int n = faultyTask.Result;  //Now, this will throw the exception that the task caused.
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
