using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GumWars.Core.Enums;

namespace GumWars.Core
{
    public class City
    {
        public City(string cityName)
        {
            this.CityMessage = String.Empty;
            this.Name = cityName;
            this.initialize();

        }

        public String Name
        {
            get;
            set;
        }

        public List<MarketGum> Gums
        {
            get;
            set;
        }

        public MarketGum FindGum(OwnedGum gum)
        {
            if (gum == null)
                return null;

            foreach (MarketGum g in this.Gums)
            {
                if (g.Name == gum.Name)
                    return g;
            }
            return null;
        }

        public String CityMessage
        {
            get;
            set;
        }

        public MarketState MarketChanged()
        {
            bool randomProbability = MyRandom.SomethingHappened(Settings.PROBABILITY_COLLAPSED_MARKET_STATE);

            int targetGum = MyRandom.Random(0, this.Gums.Count - 1);
            MarketGum g = this.Gums[targetGum];

            if (randomProbability)
            {
                double discountFactor = MyRandom.Random(35, 65) / (double)100;
                g.CurrentPrice = (int)Math.Ceiling(g.CurrentPrice * discountFactor);
                this.CityMessage = "Prices of " + g.Name + " have tanked!";

                ///Other gums are slightly depressed as well
                foreach (MarketGum mGum in this.Gums)
                {
                    if (mGum.Name == g.Name)
                        continue;
                    double discountFactor2 = MyRandom.Random(80, 90) / (double)100;
                    mGum.CurrentPrice = (int)Math.Ceiling(mGum.CurrentPrice * discountFactor2);
                }

                return MarketState.Collapsed;
            }

            randomProbability = MyRandom.SomethingHappened(Settings.PROBABILITY_SPIKED_MARKET_STATE);

            if (randomProbability)
            {
                double spikeFactor = MyRandom.Random(125, 165) / (double)100;
                g.CurrentPrice = (int)Math.Floor(g.CurrentPrice * spikeFactor);
                this.CityMessage = "Prices of " + g.Name + " have spiked!";

                ///Other gums are slightly more expensive too
                foreach (MarketGum mGum in this.Gums)
                {
                    if (mGum.Name == g.Name)
                        continue;
                    double spikeFactor2 = MyRandom.Random(110, 120) / (double)100;
                    mGum.CurrentPrice = (int)Math.Ceiling(mGum.CurrentPrice * spikeFactor2);
                }

                return MarketState.Spiked;
            }
            return MarketState.Normal;
        }

        public void GenerateMarket()
        {
            this.initialize();
        }



        public void initialize()
        {
            this.Gums = new List<MarketGum>();

            for (int i = 0; i < Settings.GUMS.Length; i++)
            {
                MarketGum gum = new MarketGum(Settings.GUMS[i], (i + 2) * 3, (i + 2) * 6);
                this.Gums.Add(gum);
            }
        }
    }


}
