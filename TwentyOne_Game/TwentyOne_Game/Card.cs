using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    //making card class a struct- nothing is inheriting from Card
    public struct Card
    {
        //public Card()
        //{
        //    //this is a constructor; value assigned to object upon creation
        //    //the constructor methods name is always the name of the class
        //    //Suit = "Spades";
        //    //Face = "Two";
        //}
        //creating property in the object
        //Suit Suit and Face Face is enum type
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}