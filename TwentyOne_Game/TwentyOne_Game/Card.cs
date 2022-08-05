using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    public class Card
    {
        public Card()
        {
            //this is a constructor; value assigned to object upon creation
            //the constructor methos name is always the name of the class
            Suit = "Spades";
            Face = "Two";
        }
        //creating property in the object
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
