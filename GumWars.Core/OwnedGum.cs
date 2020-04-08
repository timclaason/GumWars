using System;

namespace GumWars.Core
{
    public class OwnedGum
    {
        public String Name
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }

        public int TotalPaid
        {
            get;
            set;
        }

        public int AveragePrice
        {
            get
            {
                double returnVal = this.TotalPaid / (double)Quantity;
                return (int)returnVal;
            }
            
        }
    }
}
