using System;
using System.Collections.Generic;
using GumWars.Core.Enums;

namespace GumWars.Core
{
    public class Player
    {
        public Player()
        {
            this.CarryingCapacity = Settings.DEFAULT_CARRYING_CAPACITY;
            this.Money = Settings.DEFAULT_MONEY;
            this.OwnedGums = new List<OwnedGum>();
            this.Loan = Settings.DEFAULT_LOAN_AMOUNT;
            this.LoanOriginDay = this.Loan > 0 ? Settings.DEFAULT_DAYS : 0;
        }

        public int CarryingCapacity
        {
            get;
            set;
        }

        public int Money
        {
            get;
            set;
        }

        public int Loan
        {
            get;
            set;
        }

        public int LoanOriginDay
        {
            get;
            set;
        }

        public int TotalWealth
        {
            get
            {
                return (this.Money + this.Bank) - this.Loan;
            }
        }

        public List<OwnedGum> OwnedGums
        {
            get;
            set;
        }

        public int Bank
        {
            get;
            set;
        }

        public bool OwnsGum(MarketGum gum)
        {
            return this.HowManyOwned(gum) > 0;
        }

        public int RemainingCapacity
        {
            get
            {
                int returnValue = this.CarryingCapacity;

                foreach (OwnedGum g in this.OwnedGums)
                {
                    returnValue -= g.Quantity;
                }
                return returnValue;
            }
        }

        public int HowManyOwned(MarketGum gum)
        {
            foreach (OwnedGum g in this.OwnedGums)
            {
                if (g.Name == gum.Name)
                    return g.Quantity;
            }
            return 0;
        }

        public GameResult AddCapacity(int capacity, int price)
        {            
            if (price > this.Money || capacity < 0)
                return GameResult.NotEnoughMoney;
            this.CarryingCapacity = capacity;
            this.Money -= price;
            return GameResult.Success;
        }

        private GameResult buyGum(MarketGum gum, int quantity, int transactionCost)
        {
            if (transactionCost > this.Money)
                return GameResult.NotEnoughMoney;
            if (quantity > this.RemainingCapacity)
                return GameResult.NotEnoughCapacity;
            if (quantity < 0)
                return GameResult.NotEnoughMoney;

            OwnedGum ownedGum = new OwnedGum();
            ownedGum.Name = gum.Name;
            ownedGum.Quantity = quantity;

            if (this.OwnsGum(gum) == false)
            {
                if (transactionCost == 0)
                    ownedGum.TotalPaid = 0;
                else
                    ownedGum.TotalPaid = transactionCost;
                this.OwnedGums.Add(ownedGum);
            }
            else
            {
                foreach (OwnedGum g in this.OwnedGums)
                {
                    if (g.Name == gum.Name)
                    {
                        int totalCostSoFar = g.Quantity * g.AveragePrice;
                        int totalCostForThisTransaction = transactionCost;
                        double newAverage = (totalCostSoFar + totalCostForThisTransaction) / (double)(g.Quantity + quantity);
                        int averagePrice = (int)Math.Ceiling(newAverage);
                        g.Quantity += quantity;
                        g.TotalPaid += (transactionCost);                        
                    }
                }
            }
            this.Money -= transactionCost;
            return GameResult.Success;
        }

        public GameResult BuyGum(MarketGum gum, int quantity)
        {
            int price = gum.CurrentPrice * quantity;
            return buyGum(gum, quantity, price);
        }

        public GameResult BuyGum(MarketGum gum, int quantity, int totalCost)
        {
            return buyGum(gum, quantity, totalCost);
        }

        public GameResult SellGum(MarketGum gum, int quanitity)
        {
            if (this.OwnsGum(gum) == false)
                return GameResult.YouDontOwnThisGum;
            if (this.HowManyOwned(gum) < quanitity)
                return GameResult.YouDontOwnEnough;

            bool sellingAll = quanitity == this.HowManyOwned(gum);

            int proceeds = gum.CurrentPrice * quanitity;
            this.Money += proceeds;

            for (int i = 0; i < this.OwnedGums.Count; i++)
            {
                OwnedGum g = this.OwnedGums[i];
                if (g.Name == gum.Name)
                {
                    if (sellingAll)
                        this.OwnedGums.RemoveAt(i);
                    else
                        g.Quantity -= quanitity;
                }
            }

            return GameResult.Success;
        }

        public GameResult Deposit(int amount)
        {
            if (amount > this.Money || amount < 0)
                return GameResult.NotEnoughMoney;

            this.Money -= amount;
            this.Bank += amount;
            return GameResult.Success;
        }

        public GameResult Withdraw(int amount)
        {
            if (amount > this.Bank || amount < 0)
                return GameResult.NotEnoughMoney;

            this.Money += amount;
            this.Bank -= amount;
            return GameResult.Success;
        }

        public GameResult Borrow(int amount, Game game)
        {
            if(this.Loan > 0 || amount <= 0 || amount > (this.Money * Settings.MAX_LOAN_MULTIPLIER))
            {
                return GameResult.NotEnoughMoney;
            }
            this.Loan += amount;
            this.LoanOriginDay = game.DaysLeft;
            this.Money += amount;
            return GameResult.Success;
        }

        public GameResult Payback(int amount)
        {
            if (this.Loan <= 0 || amount <= 0 || amount < this.Loan)
                return GameResult.NotEnoughMoney;
            if (amount > this.Loan)
                amount = this.Loan;
            this.Loan = 0;
            this.LoanOriginDay = 0;
            this.Money -= amount;
            return GameResult.Success;
        }
    }

}
