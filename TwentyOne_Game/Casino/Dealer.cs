﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        ////methods//
        ////giving Dealer class the ablity to deal.
        ////takes input parameter a List of cards ("Hand") + adds a Card to that hand that passed in
        public void Deal(List<Card> Hand)
        {
            //Hand.Add- adding the card to the "Hand"(lists have built-in method "Add" to add to the list) 
            //"Deck" is composed of a list of cards as one of its properties
            //"First" is a method available to a list which takes the 1st item in that list
            //Grab 1st 'Card' and add it to the 'Hand' that is passed in to deal. Then print which card was added to the hand to the console
            Hand.Add(Deck.Cards.First());
            //logging text
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //logging a stream
            //"true" is yes, I want to append
            using (StreamWriter file = new StreamWriter(@"C:\Users\Esque\source\repos\log.txt", true))
            {
                file.WriteLine(DateTime.Now);   //using DateTime value 
                file.WriteLine(card);   //appending and logging this file
            }
            //Removing Card from the deck. "RemoveAt" is a method that any list has passing in an index where you want to remove
            Deck.Cards.RemoveAt(0);

        }
    }
}
