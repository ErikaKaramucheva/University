namespace AConsumerProducerRevisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the PC service.");
            MyConsumerProducer<string> pc = new(data => Console.WriteLine(data));
            pc.Run();
            pc.ProduceData("Test");
            Console.WriteLine("Press ENTER to stop the PC...");
            Console.ReadLine();
            Console.WriteLine("Stopping the PC.");
            pc.Stop();
            Console.WriteLine("PC stopped.");
            Console.ReadLine();
        }
    }
}
