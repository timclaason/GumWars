using System;
using System.Collections.Generic;
using GumWars.Core.Enums;

namespace GumWars.Core
{
    public class Game
    {
        int _daysLeft = Settings.DEFAULT_DAYS;

        List<City> _cities;

        City _currentCity;

        Player _player;

        public Game()
        {
            initialize();
        }

        public Player Player
        {
            get
            {
                return _player;
            }
        }

        public int DaysLeft
        {
            get
            {
                return _daysLeft;
            }
        }

        public bool GameIsOver
        {
            get
            {
                return _daysLeft >= 0;
            }
        }

        public String CurrentMessage
        {
            get;
            set;
        }


        private void initialize()
        {
            _cities = new List<City>();

            _player = new Player();
            foreach (String city in Settings.CITIES)
                _cities.Add(new City(city, _player));

            _currentCity = _cities[0];
            
        }

        public void Move(City city)
        {
            _currentCity = city;
            _daysLeft--;
            this.CurrentMessage = String.Empty;            
            city.GenerateMarket();
            city.MarketChanged();
            this.CurrentMessage += city.CityMessage;
            this.RandomFortuneHappened();
            this.accumulateBankInterest();
            this.accumulateLoanInterest();
            this.interveneLoanShark();
        }

        private void accumulateLoanInterest()
        {
            if (_player.Loan == 0)
                return;

            double interest = _player.Loan * Settings.DEFAULT_LOAN_INTEREST_RATE;
            int interestAmount = (int)Math.Ceiling(interest);
            _player.Loan += interestAmount;
        }

        private void interveneLoanShark()
        {
            if (_player.Loan == 0)
                return;
            int loanAge = _player.LoanOriginDay - this.DaysLeft;

            if (loanAge == 4)
            {
                if (_player.Money > 0)
                {
                    double half = _player.Money / 2.0;
                    int intMoney = (int)half;
                    _player.Money -= intMoney;
                    this.CurrentMessage += "The loan shark was tired of waiting.  He took $" + intMoney;
                }
            }
            if(loanAge == 7)
            {
                if(_player.OwnedGums.Count > 0 && _player.OwnedGums[0].Quantity > 0)
                {
                    OwnedGum gum = _player.OwnedGums[0];
                    _player.OwnedGums[0].Quantity = 1;
                    this.CurrentMessage += "The loan shark was tired of waiting.  He took most of your " + gum.Name;
                }
            }
            if(loanAge == 10)
            {
                _player.Money = 0;
                this.CurrentMessage += "The loan shark took all of your money.  You should have payed him!";
            }

        }


        private void accumulateBankInterest()
        {
            if (_player.Bank == 0)
                return;
            int interest = (int)(_player.Bank * Settings.BANK_INTEREST_RATE);
            _player.Bank += interest;
        }

        public void Move(string city)
        {
            foreach (City c in _cities)
            {
                if (c.Name == city)
                {
                    this.Move(c);
                    break;
                }
            }
        }

        public List<City> Cities
        {
            get
            {
                return _cities;
            }
        }

        public City CurrentCity
        {
            get { return _currentCity; }
        }

        public RandomFortunes RandomFortuneHappened()
        {
            bool gainedGum = MyRandom.SomethingHappened(Settings.RANDOM_FORTUNE_GAIN_GUM_PROBABILITY);

            if (gainedGum)
            {
                if (this.Player.RemainingCapacity < 100)
                    return RandomFortunes.None;
                int randomGum = MyRandom.Random(0, this.CurrentCity.Gums.Count - 1);
                int randomCapacity = MyRandom.Random(50, this.Player.RemainingCapacity - 10);
                this.Player.BuyGum(this.CurrentCity.Gums[randomGum], randomCapacity, 0);
                this.CurrentMessage += "You found " + randomCapacity + " boxes of " + this.CurrentCity.Gums[randomGum].Name + "!";
                return RandomFortunes.GainGum;
            }

            bool gainedCapacity = MyRandom.SomethingHappened(Settings.RANDOM_FORTUNE_GAIN_CAPACITY_PROBABILITY);
            if (gainedCapacity)
            {
                int newCapacity = MyRandom.Random(this.Player.CarryingCapacity + 250, this.Player.CarryingCapacity + 1000);
                this.CurrentMessage += "You now have " + newCapacity + " carrying capacity!";
                this.Player.CarryingCapacity = newCapacity;
                return RandomFortunes.GainCapacity;
            }

            bool gainedMoney = MyRandom.SomethingHappened(Settings.RANDOM_FORTUNE_GAIN_MONEY_PROBABILITY);

            if (gainedMoney)
            {
                int money = MyRandom.Random(1000, this.Player.Money + 500);
                this.CurrentMessage += "You found $" + money + "!";
                this.Player.Money += money;
                return RandomFortunes.GainMoney;
            }

            bool lostMoney = MyRandom.SomethingHappened(Settings.RANDOM_FORTUNE_LOSE_MONEY_PROBABILITY);

            if (lostMoney)
            {
                if (this.Player.Money <= 100)
                    return RandomFortunes.None;
                double maxMoney = this.Player.Money * .75;

                int money = MyRandom.Random(100, (int)maxMoney);
                this.CurrentMessage += "You lost $" + money + " in a Ponzi scheme.";
                this.Player.Money -= money;
                return RandomFortunes.LostMoney;
            }

            bool lostGum = MyRandom.SomethingHappened(Settings.RANDOM_FORTUNE_LOSE_GUM_PROBABILITY);

            if(lostGum)
            {
                if (this.Player.OwnedGums.Count == 0)
                    return RandomFortunes.None;

                OwnedGum gum = this.Player.OwnedGums[0];

                if (gum.Quantity < 5)
                    return RandomFortunes.None;

                double maxGumLost = gum.Quantity / 2.0;
                int amountLost = MyRandom.Random(1, (int)maxGumLost);
                gum.Quantity -= amountLost;
                this.CurrentMessage += "Someone has stolen " + amountLost + " boxes of " + gum.Name;
                return RandomFortunes.LostGum;
            }




            return RandomFortunes.None;
        }

    }

}
