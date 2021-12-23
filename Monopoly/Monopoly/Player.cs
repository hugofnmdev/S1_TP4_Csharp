using System;
using System.Collections.Generic;

namespace Monopoly
{
    public class Player
    {
        private List<Property> possessions;
        private int balance;
        private int position;
        private string name;
        public bool jailed;

        public List<Property> Possession => this.possessions;
        public int Balance => this.balance;
        public int Position => this.position;
        public string Name => this.name;

        public Player(string name, int initialBalance, int initialPosition)
        {
            this.name = name;
            this.balance = initialBalance;
            this.position = initialPosition;
            List<Property> list = new List<Property>();
        }
        public void ReceiveMoney(int amount)
        {
            balance += amount;
        }

        public bool RetrieveMoney(int amount)
        {
            if (balance <= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Buy(Property p)
        {
            if (balance <= p.Price)
            {
                RetrieveMoney(p.Price);
                possessions.Add(p);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Sell(Property p)
        {
            ReceiveMoney(p.Price);
            possessions.Remove(p);
            return true;
        }
        
        public bool TransferTo(Player p, int amount)
        {
            if (balance <= amount)
            {
                RetrieveMoney(amount);
                p.ReceiveMoney(amount);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool SellTo(Property p, Player player)
        {
            if (possessions.Contains(p))
            {
                player.RetrieveMoney(p.Price);
                ReceiveMoney(p.Price);
                possessions.Remove(p);
                player.possessions.Add(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int vector, int boardSize)
        {
            int positionmax = position + vector; 
            if (positionmax > boardSize)
            {
                position = vector - (boardSize - position) - 1;
            }
            else
            {
                position += vector;
            }
        }

        public void SendToJail()
        {
            jailed = true;
        }
        
        /*=
        public override string ToString()
        {
            string pos = this.possessions.Count > 0 ? this.possessions[0].Name : "";

            for (int i = 1; i < this.possessions.Count; i++)
                pos += ", " + this.possessions[i].Name;
            
            return "player: '" + this.name + "'\n"
                       + "balance: " + this.balance + " £\n"
                       + "position: " + this.position + "\n"
                       + "possessions: " + pos;
        }
        */
    }
}