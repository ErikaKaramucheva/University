using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication
{
    class Salesman:Employee
    {
        private double comission;
        private double baseSalary { get; set; }
        public double Comission
        {
            get { return comission; }
            set { comission = value; }
        }

        public override double salary => baseSalary+comission;

        public Salesman(string name, double baseSalary, double comission)
            : base(name)
        {
            this.baseSalary = baseSalary;
            this.comission = comission;
        }
    }
}
