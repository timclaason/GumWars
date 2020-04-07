using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumWars.Core
{
    public class MarketGum : Gum
    {
        private int _price;

        public MarketGum(string name, int minPrice, int maxPrice)
        {
            this.Name = name;
            _price = MyRandom.Random(minPrice, maxPrice);
        }

        public int CurrentPrice
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
