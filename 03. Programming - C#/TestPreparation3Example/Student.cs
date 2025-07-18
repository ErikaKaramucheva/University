using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation3Example
{
    class Student:Person
    {
        private double averageGrade;
        public double AverageGrade
        {
            get
            {
                return averageGrade;
            }
            set
            {
                averageGrade = value;
            }
        }

        public Student(string name, string egn, string gender, double averageGrade)
            : base(name, egn, gender)
        {
            this.averageGrade = averageGrade;
        }
    }
}
