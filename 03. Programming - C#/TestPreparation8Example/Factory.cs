using System;
using System.Collections.Generic;
using System.Text;

namespace TestPreparation8Example
{
    class Factory
    {
        private int countOfRealisedDetails;

        Details det1 = new Details(2.4, 3.2, 1);
        Details det2 = new Details(1.7, 5, 1.2);
        Details det3 = new Details(3, 0.4, 2.5);
        Details det4 = new Details(2, 1, 3);

      public Factory(int count)
        {
            countOfRealisedDetails = count;
        }

        public override string ToString()
        {
            return "Width: " + idth + ". Height: " + Height + ". Length: " + length + ".";
        }
        public int CountOfRealisedDetails
        {
            get
            {
                return countOfRealisedDetails;
            }
            set
            {
                countOfRealisedDetails = value;
            }
        }
    }
}
