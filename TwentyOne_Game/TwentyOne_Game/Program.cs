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
            TwentyOneGame game = new TwentyOneGame();
            //calling super class method, "game"
            game.Players = new List<string>() { "Lizzy", "Bill", "Joe" };
            game.ListPLayers();
            game.Play();
            Console.ReadLine();
            ////creating object:deck
            //Deck deck = new Deck();
            ////calling method to shuffle deck 3x, sending it out + assigning variable timesShuffled
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

       
      
    }
}
