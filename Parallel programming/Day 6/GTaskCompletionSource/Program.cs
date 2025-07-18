using System.Diagnostics;

namespace GTaskCompletionSource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskCompletionSource tcs = new TaskCompletionSource();
            var myTask = tcs.Task;

            Process notepad = new Process();
            notepad.StartInfo = new ProcessStartInfo()
            {
                FileName = "notepad.exe",
            };
            notepad.EnableRaisingEvents = true;
            notepad.Exited += (s, a) =>
            {
                //This event handler is executed on the TP by the OS / kernel.
                tcs.SetResult();
            };
            notepad.Start();

            Console.WriteLine("Waiting for the task to complete.");
            myTask.Wait();

            Console.WriteLine("Press ENTER to quit.");

        }

        private static void Notepad_Exited(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
