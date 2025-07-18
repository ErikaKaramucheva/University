using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation7Example
{
    abstract class Person
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

        public Person(string name)
        {
            this.name = name;
        }
    }
}
