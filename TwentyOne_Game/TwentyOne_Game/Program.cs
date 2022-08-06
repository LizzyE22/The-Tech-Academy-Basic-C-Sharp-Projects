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
            int timesShuffled = 0;
            //method to shuffle deck 3x, sending it out + assigning variable timesShuffled
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                //temporary list to store shuffled items
                timesShuffled++;
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
            }
            return deck;
        }
        //function for shuffling more than one time
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i > times; i++)
        //    {
        //        deck = Shuffle(deck);                
        //    }
        //    return deck;
        //}
    }
}
