using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //methods//
        //giving Dealer class the ablity to deal.
        //takes input parameter a List of cards ("Hand") + adds a Card to that hand
        public void Deal(List<Card> Hand)
        {
            //Hand.Add- adding to the "Hand"(a list that has built-in method "Add" to add something to the list). 
            //"Deck" is composed of a list of cards as one of its properties
            //"First" is a method available to a list which takes the 1st item in that list
            //Grab 1st 'Card' and add it to the 'Hand' that is passed in to deal. Then print which card was dealt to the console
            Hand.Add(Deck.Cards.First());
            //the card you are about to put in the deck
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //Removing Card from the deck. "RemoveAt" is a method that any list has passing in an index where you want to remove
            Deck.Cards.RemoveAt(0);
            
        }
    }
}
