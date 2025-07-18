using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        public static Mutex mutex;
        public static ManualResetEvent mre;
        public static int currentGreenLight = 0;
        public static int currentRedLight = 0;
        public static object lockObj = new object();

        public static void SetLight(object obj)
        {
            string[] data = obj.ToString().Split(",");
            int light = int.Parse(data[1]);
            //mutex.WaitOne();
            lock (lockObj)
            {
                if (data[0].Equals("true"))
                {
                    currentGreenLight = light;
                }
                else
                {
                    currentRedLight = light;
                }
            }
            if (currentRedLight == light)
            {
                InvokeRedLight(light);
                InvokeYellowLight(light);
                InvokeGreenLight(light);
                InvokeRedLight(light);
            }
            else
            {
                InvokeGreenLight(light);
                InvokeYellowLight(light);
                InvokeRedLight(light);
            }

            Console.WriteLine(light + " end."); //for testing purposes
            // mutex.ReleaseMutex();

        }

        public static void InvokeRedLight(object obj)
        {
            Console.WriteLine($"Светофарът {obj} свети червено.");
            Thread.Sleep(1000);
            mre.Set();
            PedestrianTrafficLight($"{obj},зелено");

        }
        public static void InvokeYellowLight(object obj)
        {
            Console.WriteLine($"Светофарът {obj} свети жълто.");
            Thread.Sleep(200);
        }
        public static void InvokeGreenLight(object obj)
        {
            Console.WriteLine($"Светофарът {obj} свети зелено.");
            mre.Reset();
            PedestrianTrafficLight($"{obj},червено");
            Thread.Sleep(1000);
        }


        public static void PedestrianTrafficLight(object light)
        {
            mutex.WaitOne();
            string[] info = light.ToString().Split(",");
            Console.WriteLine($"Пешеходният светофар {info[0]} свети в {info[1]}");
            mutex.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            mutex = new Mutex();
            mre = new ManualResetEvent(false);
            Thread mainRoadAutoTrafficLight = new Thread(SetLight);
            Thread secondRoadAutoTrafficLight = new Thread(SetLight);
            mainRoadAutoTrafficLight.Start("true,1");
            secondRoadAutoTrafficLight.Start("false,2");
            mainRoadAutoTrafficLight.Join();
            secondRoadAutoTrafficLight.Join();

        }
    }
}