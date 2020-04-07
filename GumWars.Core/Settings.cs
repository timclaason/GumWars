using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumWars.Core
{
    public class Settings
    {
        public static int DEFAULT_CARRYING_CAPACITY = 600;

        public static int DEFAULT_MONEY = 1500;

        public static int DEFAULT_DAYS = 30;

        public static int DEFAULT_LOAN_AMOUNT = 0;

        public static double DEFAULT_LOAN_INTEREST_RATE = .12;

        public static int MAX_LOAN_MULTIPLIER = 5;

        public static double BANK_INTEREST_RATE = 0.06;

        public static int PROBABILITY_COLLAPSED_MARKET_STATE = 25;

        public static int PROBABILITY_SPIKED_MARKET_STATE = 18;

        public static int RANDOM_FORTUNE_GAIN_CAPACITY_PROBABILITY = 12;

        public static int RANDOM_FORTUNE_GAIN_GUM_PROBABILITY = 11;

        public static int RANDOM_FORTUNE_GAIN_MONEY_PROBABILITY = 15;

        public static int RANDOM_FORTUNE_LOSE_MONEY_PROBABILITY = 14;

        public static int RANDOM_FORTUNE_LOSE_GUM_PROBABILITY = 13;

        public static string[] CITIES = { "Altoona", "Augusta", "Eau Claire", "Elk Mound", "Fall Creek", "Osseo" };

        public static string[] GUMS =   { "Wrigleys", "Bazooka Joe", "Beemans", "Eclipse", "Big Red", "Doublemint", "Orbit", "Juicy Fruit", "WinterFresh" };

    }
}
