using MultiLevelParkingGarageSimulation;

public class Program {

    public static void Main(string[] args)
    {
        int levels = 3;
        int carsNumbers = 25;
        ParkingGarage garage = new ParkingGarage(3, 25);
        garage.Run();
        Thread.Sleep(30000);
        garage.Stop();
    }

}
