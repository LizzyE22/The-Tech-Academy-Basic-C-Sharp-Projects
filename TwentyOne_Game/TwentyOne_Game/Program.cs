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
            Deck deck = new Deck();
            //method to shuffle deck and returning value back to it
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            //temporary list to store shuffled items
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            //while loop to grab a random card, take it out of the deck and put it in temp deck
            while (deck.Cards.Count > 0)
            {
                // creating a random index b/w 0 and 52(deck.Cards.Count)
                int randomindex = random.Next(0, deck.Cards.Count);
                //adding to temp list
                TempList.Add(deck.Cards[randomindex]);
                //removing it from list of cards until there are no cards left
                deck.Cards.RemoveAt(randomindex);
            }
            //now empty deck.Cards is assigned TempList as a value and returning deck
            deck.Cards = TempList;
            return deck;


        }
    }
}
