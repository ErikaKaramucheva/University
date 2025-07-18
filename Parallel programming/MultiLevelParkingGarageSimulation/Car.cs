using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelParkingGarageSimulation
{
    internal class Car
    {
        public string Name { get; set; }
        public int Level { get; set; }

        //public Car(string name, int level)
        //{
        //    Name = name;
        //    Level = level;
        //}
        public Car(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name},{Level}";
        }
    }
}
