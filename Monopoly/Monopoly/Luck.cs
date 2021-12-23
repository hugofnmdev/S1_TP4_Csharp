using System;

namespace Monopoly
{
    public class Luck : Special
    {
        public Luck(int position)
        {
            this.position = position;
        }
        public static double GetRandomValue()
        {
            /* Implement the Box-Muller Methode in order to generate
             * random numbers
             */
            
            Random rand = new Random();
            double x, y, u;
            u = 0;
            do
            {
                x = rand.NextDouble();
                y = rand.NextDouble();
                u = x * x + y * y;
            } while (u == 0 || u >= 1);
            
            /*
             * Base on the fact that in a normal distribution
             * there is an equal chance to get a positive
             * or a negative value
             * 
             * We treat only positive values and multiply
             * by (-1)^(random positive integer) to get the
             * sign.
             */
            
            return Math.Pow(-1, rand.Next()) * x *
                   Math.Sqrt(-2 * Math.Log(u) / u);
        }

        private static int GetAmount(double rand)
        {
            //Auxiliary function to get the absolute value of the amount
            double absRand = Math.Abs(rand);
            int sign = rand < 0.0 ? -1 : 1;
            if (absRand > 1.5)
                return sign * 4000;
            if (absRand > 1)
                return sign * 2000;
            return sign * 500;
        }
        public bool MoneyEffect(Player player, double rand)
        {
            int bruh = GetAmount(rand);
            if (ModifyBudget(player, bruh))
            {
                ModifyBudget(player, bruh);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool GetEffect(Player player)
        {
            double bruh2 = GetRandomValue();
            if (bruh2 < Math.Abs(2))
            {
                MoneyEffect(player, bruh2);
                return true;
            }
            else
            {
                player.SendToJail();
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "[Luck]";
        }
    }
}