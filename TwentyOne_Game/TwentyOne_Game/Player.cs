using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    //making generic Player class by defining data type with "T"
    public class Player<T>
    {
        
        public List<T> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //adding overloaded operator method- Game is the return type
        //Inside parantheses is what is being added together (game, player (the operands)) and returning a Game

        //public static Game operator+ (Game game, Player player)
        //{
        //    game.Players.Add(player);
        //    return game;
        //}
        //public static Game operator- (Game game, Player player)
        //{
        //    //creating subtract overload operator
        //    game.Players.Remove(player);
        //    return game;
        }
    }
}
