using System;
using System.Collections.Generic;
using System.Text;

namespace DI2
{
    class Student
    {
        private int iNumber;
        private string name;
        private string lastName;
        private string town;
        private string phone;
        private double grade;

        public Student(int iNumber, string name,string lastName, string town, string phone, double grade)
        {
            this.iNumber = iNumber;
            this.name = name;
            this.lastName = lastName;
            this.town = town;
            this.phone = phone;
            this.grade = grade;
        }

        public int INumber { get { return iNumber; } set => iNumber = value; }
        public string Name { get { return name; } set => name = value; }
        public string LastName { get { return lastName; } set => lastName = value; }
        public string Town { get { return town; } set => town = value; }
        public string Phone { get { return phone; } set => phone = value; }
        public double Grade { get { return grade; } set => grade = value; }

        public override string ToString()
        {
            return "Input number: +"+iNumber+"\n Name: "+name+"\n Last Name: "+lastName+"\n Town: "+town+"\n Phone: "+phone+"\n Grade: "+grade;
        }
    }
}
