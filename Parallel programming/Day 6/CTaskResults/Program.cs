namespace CTaskResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = Task.Run(() => Random.Shared.Next(100));

            Console.WriteLine("Getting a result from a task");

            //Trying to read the result of a task before it is complete will
            //block until the task is complete.
            //Same as if you called task1.Wait before reading the result.
            Console.WriteLine($"The result is: {task1.Result}");

            Console.ReadLine();

        }
    }
}
