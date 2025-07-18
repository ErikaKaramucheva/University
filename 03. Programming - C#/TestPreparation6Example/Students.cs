using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation6Example
{
    class Students:Person
    {
        private int classNumber;
        public int ClassNumber
        {
            get
            {
                return classNumber;
            }set => classNumber = value;
        }

        public Students(string name, int classNumber)
            : base(name)
        {
            this.classNumber = classNumber;
        }
    }
}
