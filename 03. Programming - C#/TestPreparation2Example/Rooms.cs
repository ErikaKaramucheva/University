using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation2Example
{
    class Rooms : Room
    {
        private bool isHavingATerrace;
        public bool IsHavingATerrace
        {
            get
            {
                return isHavingATerrace;
            }
            set
            {
                isHavingATerrace = value;
            }
        }

        public Rooms(int beds,double area,bool isHavingATerrace)
            : base(beds, area)
        {
            this.isHavingATerrace = isHavingATerrace;
        }
    }
}
