using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation2Example
{
    class Apartment:Room
    {
        private bool haveABath;
            public bool HaveABath
        {
            get
            {
                return haveABath;
            }
            set
            {
                haveABath = value;
            }
        }

        private string personalName;
        public string PersonalName
        {
            get
            {
                return personalName;
            }
            set
            {
                personalName = value;
            }
        }

        public Apartment(int beds,double area, bool haveABath,string personalName)
            : base(beds, area)
        {
            this.haveABath = haveABath;
            this.personalName = personalName;
        }
    }
}
