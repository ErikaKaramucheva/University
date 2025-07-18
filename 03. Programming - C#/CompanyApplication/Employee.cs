using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApplication
{
    public abstract class Employee
    {
        public string name { get; set; }
        public abstract double salary { get; }

        public Employee(string name)
        {
            this.name = name;
        }

    }
}
