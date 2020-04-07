using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumWars.Core
{
    public class MyRandom
    {
        [ThreadStatic]
        static Random random;
        static Random Get()
        {
            if (random == null) random = new Random(Guid.NewGuid().GetHashCode());
            return random;
        }


        public static int Random(int min, int max)
        {
            max = max + 1;

            if (max < min)
            {
                int temp = max;
                max = min;
                min = temp;
            }
            Random r = MyRandom.Get();
            return r.Next(min, max);
        }

        /// <summary>
        /// Probability between 1 and 100
        /// </summary>
        /// <param name="probability"></param>
        /// <returns>True if it happened, based on probability</returns>
        public static bool SomethingHappened(int probability)
        {
            if (probability < 1)
                return false;
            if (probability > 100)
                return true;

            int randomNumber = Random(1, 100);

            return randomNumber <= probability;
        }
    }
}
