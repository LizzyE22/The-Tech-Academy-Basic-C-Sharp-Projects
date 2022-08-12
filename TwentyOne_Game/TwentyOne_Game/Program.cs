using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            //parameters game and player return a game
            game += player; //same as game = game + player;
            game -= player; // same as game = game - player;

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPLayers();
            //Console.ReadLine();

            //TwentyOneGame object morphing into a Game object
            //Game game = new TwentyOneGame();

            //Inheritance and calling method ListPlayers////////////
            //TwentyOneGame game = new TwentyOneGame();
            ////calling super class method, "game"
            //game.Players = new List<string>() { "Lizzy", "Bill", "Joe" };
            //game.ListPLayers();
            //game.Play();
            //Console.ReadLine();
            ////creating object:deck
            Deck deck = new Deck();
            //calling method to shuffle deck 3x, sending it out + assigning variable timesShuffled
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }



    }
}
