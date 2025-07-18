using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication
{
    class Administrator : Employee
    {
        private double fixedSalary;
        public double FixedSalary{
             get
            {
                    return fixedSalary;
                } set{
                    fixedSalary = value;
                }
            }
        public override double salary => fixedSalary;
        public Administrator(string name, double fixedSalary)
            :base(name)
        {
            fixedSalary = salary;
        }
    }
}
