using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation3Example
{
    class Teacher:Person
    {
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Teacher(string name, string egn,string gender,int salary)
            : base(name, egn, gender)
        {
            this.salary = salary;
        }
    }
}
