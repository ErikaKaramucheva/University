using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation1
{
    class Person
    {
        public string name;
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

       // public Person(string name)
       // {
        //    this.name = name;
       // }

        public string returnPersonName()
        {
            return name;
        }
    }
}
