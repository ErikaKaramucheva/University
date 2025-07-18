
using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("PB2467AC", "KIA", "SPORTAGE", "YELLOW", 24650, 2014,Motor.diesel);
            Auto a2 = new Auto("PB7235AN", "PEUGEOT", "307", "BLACK", 6700, 2003,Motor.diesel);
            Auto a3 = new Auto("SM1152TD", "KIA", "RIO", "WHITE", 14900, 2018,Motor.gasoline);

             List<Auto> autopark = new List<Auto>();
            autopark.Add(a1);
            autopark.Add(a2);
            autopark.Add(a3);


            var result = Autos(autopark);
            foreach(Auto a in result)
            {
                Console.WriteLine(a.ToString());
            }
            
        }

        public static IEnumerable<Auto> Autos(List<Auto> auto)
        {
            var result= auto.Where(x => x.Make == "KIA");
            result = result.Where(x => x.Year >= 2012 && x.Year <= 2015);
            result = result.Where(x => x.RegNumber.StartsWith("PB"));
            return result;
        }

    }
}
