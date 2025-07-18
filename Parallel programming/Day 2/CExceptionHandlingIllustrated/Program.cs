namespace CExceptionHandlingIllustrated
{
    internal class Program
    {
        static void M1()
        {
            Console.WriteLine("M1 starts.");
            M2();
            Console.WriteLine("M1 ends.");
        }
        static void M2()
        {
            Console.WriteLine("M2 starts.");
            try
            {
                Int32.Parse("abb");
            }
            catch (IOException)
            {
                Console.WriteLine("Problem with IO, but I can go on.");
            }
            Console.WriteLine("M2 ends.");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Main starts.");
            try
            {
                M1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("M1 crashed spectacularly.");
            }
            Console.WriteLine("Main ends");
        }
    }
}
