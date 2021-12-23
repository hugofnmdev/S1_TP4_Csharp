using System;
using System.Collections.Generic;    

namespace Monopoly
{
    public class Game
    {
        private const int BeginCell = 200;
        private List<Cell> board;
        private List<Player> players;
        private int playersNumber;
        private int boardSize;
        public int BoardSize => boardSize;
        public List<Player> Players => players;
        public int PlayersNumber => playersNumber;
        public List<Cell> Board => board;

        public Game(int boardSize)
        {
            //TODO
            throw new NotImplementedException();
        }

        public int RollDice()
        {
            //TODO
            throw new NotImplementedException();
        }
        private int GetInput(Player player, Property property)
        {
            //TODO
            throw new NotImplementedException();
        }
        public void BuyProperty(Property property, Player player, int input)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool OnRegular(Cell cell, Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool OnTax(Tax tax, Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool PlayRound(Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool PlayerWon()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void PlayerLost(Player player)
        {
            //TODO
            throw new NotImplementedException();
        }

        public void AddBoard(Cell cell)
        {
            boardSize++;
            board.Add(cell);
        }

        /*
        public void AddPlayer(Player player)
        {
            this.playersNumber++;
            this.players.Add(player);
        }
        */

        public void Play()
        {
            //TODO
            throw new NotImplementedException();
        }

        /*
        public void DisplayBoard()
        {
            int position = 0;
            foreach (Cell c in this.board)
            {
                Console.WriteLine(c);
                foreach (Player player in players)
                {
                    if (player.Position == position)
                        Console.WriteLine("\t* " + player.Name + " (" + player.Balance +
                                          "£)");
                }
                ++position;
            }
        }
        */
    }
}