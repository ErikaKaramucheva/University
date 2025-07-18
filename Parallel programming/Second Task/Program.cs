static void printName(object name)
{
    Console.WriteLine($"Hello {name}");
}

Thread thread = new Thread(printName);
thread.Start("Erika");
Console.WriteLine("End of my console app.");