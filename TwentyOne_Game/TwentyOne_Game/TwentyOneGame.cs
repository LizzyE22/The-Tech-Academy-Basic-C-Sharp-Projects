using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    //public class TwentyOneGame inherits from class Game
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        //implementing abstract method in inheriting class with "override"
        public override void Play()
        {
            Dealer = new TwentyOneDealer();     //instantiating new dealer
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                //passing in amount they enter into Bet method
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    //isn't returning anything but says, "end this method"
                    return;
                }
                //Bets represents the dictionary and player is the key
                Bets[player] = bet;
            }
        }
                   
        public override void ListPLayers()
        {
            Console.WriteLine("21 Players: ");
            //this auto pops up and is the same as the foreach loop in "Game" class
            base.ListPLayers();
        }
        //return Type (void) must match the return type in the interface
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}

