using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    public class Deck
    {
        //constructor assigns values to an object immediately upon creation
        //contructor method name is always the same as class
        public Deck()
        {
            //"Cards" refers to the property of the class-no need for variable or type name
            Cards = new List<Card>();
            //nested foreach loop
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);

                }
            }
 
        }
        //Cards property which is a list
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            //timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                //temporary list to store shuffled items
                //timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                //while loop to grab a random card, take it out of the deck and put it in temp deck
                while (Cards.Count > 0)
                {
                    // creating a random index b/w 0 and 52(deck.Cards.Count)
                    int randomindex = random.Next(0, Cards.Count);
                    //adding to temp list
                    TempList.Add(Cards[randomindex]);
                    //removing it from list of cards until there are no cards left
                    Cards.RemoveAt(randomindex);
                }
                //now empty deck.Cards is assigned TempList as a value and returning deck
                Cards = TempList;
            }
        }
    }
}
