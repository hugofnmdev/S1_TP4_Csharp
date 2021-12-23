using System;

namespace Monopoly
{
    public class Tax : Special
    {

        private int amount;
        public int Amount => this.amount;

        public Tax(int amount, int position)
        {
            this.amount = amount;
            this.position = position;
        }

        public bool TaxPlayer(Player player)
        {
            return ModifyBudget(player, amount);
        }

        /*
        public override string ToString()
        {
            return "[Tax]: " + this.amount + "£";
        }
        */
    }
}