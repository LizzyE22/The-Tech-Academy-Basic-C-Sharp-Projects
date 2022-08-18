using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //making generic Player class by defining data type with "T"
    //public class Player<T>
    public class Player
    {
        //constructor call chain example
        public Player(string name) : this(name, 100)
        {

        }
        //constructor taking 2 parameters(arguments); name and beginningBalance
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();        //initializing list
            Balance = beginningBalance;     //assigning arguments to properties of this object
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }    //adding Guid property

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //adding overloaded operator method- Game is the return type
        //Inside parantheses is what is being added together (game, player (the operands)) and returning a Game
        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            //creating subtract overload operator
            game.Players.Remove(player);
            return game;
        }
    }
}
