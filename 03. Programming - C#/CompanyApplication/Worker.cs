using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication
{
    class Worker:Employee
    {
        public override double salary => rate*workingHours;

        private double rate { get; set; }
        private double workingHours { get; set; }

        public Worker(string name, double rate, double workingHours)
            :base(name)
        {
            this.rate = rate;
            this.workingHours = workingHours;
        }

    }
}
