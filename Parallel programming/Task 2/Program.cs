static void printGreeting(object name)
{
    Console.WriteLine("Hello " + name);
}

Thread t1= new Thread(printGreeting);
t1.Start("Erika");
Console.WriteLine("End of my console app");
