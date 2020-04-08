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

        private Player _player;

        public MarketGum(string name, int minPrice, int maxPrice, Player player)
        {
            this.Name = name;
            _player = player;
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

        public int CanAfford
        {
            get
            {
                double amt = _player.Money / this.CurrentPrice;
                return (int)Math.Floor(amt);
            }
        }
    }
}
