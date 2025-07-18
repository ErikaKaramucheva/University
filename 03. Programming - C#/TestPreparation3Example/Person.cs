using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation3Example
{
   abstract  class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string egn;
        public string Egn
        {
            get
            {
                return egn;
            }
            set
            {
                egn = value;
            }
        }

        private string gender;
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public Person(string name, string egn,string gender)
        {
            this.name = name;
            this.egn = egn;
            this.gender = gender;
        }
    }
}
