namespace IRaceConditionList
{
    internal class Program
    {
        static List<double> doubles = new List<double>();

        static void Generator()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                doubles.Add(Random.Shared.NextDouble());
            }
        }

        static void Main(string[] args)
        {
            var threads = Enumerable.Range(1, Environment.ProcessorCount)
                .Select(i => new Thread(Generator)).ToArray();
            foreach (var t in threads) t.Start();
            foreach (var t in threads) t.Join();
        }
    }
}
