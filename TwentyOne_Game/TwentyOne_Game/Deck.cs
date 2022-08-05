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
    }
}
