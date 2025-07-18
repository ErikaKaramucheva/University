namespace FLongRunningTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var longRunningTask = new Task(
                () => Thread.Sleep(5000),
                TaskCreationOptions.LongRunning);
            longRunningTask.Start();
        }
    }
}
