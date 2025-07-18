using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelParkingGarageSimulation
{
    internal class ParkingGarage
    {
        private int levels;
        private int capacity = 5;
        private SemaphoreSlim[] semaphores;
        private object lockObj = new object();
        private Random random = new Random();
        Queue<Car> cars = new Queue<Car>();
        private int carsNumber;
        private ManualResetEvent workSignal=new ManualResetEvent(true);
        private bool isRunning = true;


        public ParkingGarage(int levels, int carsNumber) {

            this.levels = levels;
            this.carsNumber = carsNumber;
            semaphores = new SemaphoreSlim[levels];

            for (int i = 0; i < levels; i++)
            {
                semaphores[i] = new SemaphoreSlim(capacity, capacity);
            }

        }
        public void LeaveGarage(Car car)
        {
                int time = random.Next(501);
                Console.WriteLine($"Car {car.Name} wait before leaving {car.Level}.");
                Thread.Sleep(time);
                lock (lockObj)
                {
                    cars.TryDequeue(out car);
                    semaphores[car.Level-1].Release();
                    Console.WriteLine($"Car {car.Name} left Level {car.Level}");
                }
        }

        public void EnterParking(object car)
        {
            Car currentCar = new Car(car.ToString());
            int choosenLevel = random.Next(1, levels + 1);
            Console.WriteLine($"Car {currentCar} is trying to park on {choosenLevel - 1} level.");
            int time = random.Next(1000);
            if (semaphores[(choosenLevel - 1)].Wait(time))
            {
                lock (lockObj)
                {
                    currentCar.Level = choosenLevel;
                    Console.WriteLine($"Car {currentCar} parked at Level {choosenLevel - 1}");
                    cars.Enqueue(currentCar);
                }
                new Thread(() => LeaveGarage(currentCar)).Start();
            }
            else
            {
                Console.WriteLine($"No free spot. Car {car} left without parking.");
            }
        }
        

        private void Worker(object car) {
            Car currentCar = new Car(car.ToString());
            while (isRunning)
            {
                EnterParking(car);
                Thread.Sleep(random.Next(500, 2000));
                
            }
        }

        List<Thread> carThreads = new List<Thread>();
        
        public void Run()
        {
            isRunning = true;
            Console.WriteLine("Parking is opened.");
            for(int i = 0; i < carsNumber; i++)
            {
                var thread= new Thread(Worker);
                thread.Start(i.ToString());
                carThreads.Add(thread);
            }

        }

        public void Stop()
        {
            isRunning = false;
            workSignal.Reset();
            foreach(var t in carThreads)
            {
                t.Join();
            }
            Console.WriteLine("Parking garage is closed");
        }
    } 


    
}
