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
            Dealer.Deck.Shuffle();
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
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    //passing in the players hand thats given a card- that card is printed to the console
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        //static method-preface it with class name
                        //passing in players Hand to check it for blackjack
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1})", player.Name, Bets[player]);
                            //adding amount to balance if player won
                            //in 21, rules apply that you win your bet * 1.5 + you get your bet back
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]);
                            return;
                        }
                    }
;                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);   //deal the dealers hand
                if (i == 1)
                {
                    //static method prefacing with class name
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        //giving the dealer all the bets
                        //iterating through dictionary + assigned dealer the balance of everything
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                //focus on a player and continue asking them to hit or stay until they say "stay"
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        //2 string method that shows player their cards
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");  //"\n" means give space in the console
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);   //passing in Hand and they'll get a card
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //will return true or false
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);  
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);   //dealing the dealer a card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                //looping through each key value pair
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    //this person won this amount... all based on whats in the Bets table
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //finding player in players list that matches that key value pair
                    //calling "First" player to grab the first name from the new list created by "Where",
                    //take their balance and add what they bet * 2 to their balance
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;  //taking dealer and minusing bet from dealer
                }
                return;
            }
            //compare players value in their hand vs. dealer- whoever has higher amount wins
            foreach (Player player in Players)
            {
                //creating boolean able to take the value "null"
                //turns boolean data type into a nullable boolean
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //player gets the money she bet back
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);   //if player wins, they get their bet back as winnings (*2)
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];

                }
                Console.WriteLine("Play again!");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
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

