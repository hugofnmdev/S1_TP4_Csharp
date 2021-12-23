using System;
using System.ComponentModel.Design;

namespace Monopoly
{
    public abstract class Special : Cell
    {
        protected bool ModifyBudget(Player player, int amount)
        { 
            if (amount > 0)
            {
                player.ReceiveMoney(amount); 
                return true;
            }
            if (amount < 0)
            { 
                player.RetrieveMoney(amount); 
                return true;
            }
            return false;
        }
    }
}