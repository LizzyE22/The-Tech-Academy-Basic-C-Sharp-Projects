using System;
using System.IO;
using Casino;
using Casino.TwentyOne_Game;

namespace TwentyOne_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a constant example
            //const string casinoName = "Grand Hotel and Casino";
            //Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            //exception handling for user inputs
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                //TryParse is a method; takes a string and has an out parameter (bank)
                validAnswer = int.TryParse(Console.ReadLine(), out bank);   //'int.' is same as Int32
                if (!validAnswer) Console.WriteLine("Please enter digits only, and no decimals");
            }
            
            Console.WriteLine("Hello, {0}, Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();     //Guid example; property in Player class
                using (StreamWriter file = new StreamWriter(@"C:\Users\Esque\source\repos\log.txt", true))
                {
                    file.WriteLine(player.Id);   //continuing Guid example
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }



            //Struct example//
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);


            ////Another enum example//
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            ////casting enum string to an integer...return is "1"
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            ///Enum example//
            //DaysofTheWeek day = DaysofTheWeek.Monday;

            ///Generics example///
            //Player<Card> player = new Player<Card>();
            //player.Hand = new List<Card>();


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            ////parameters game and player return a game
            //game += player; //same as game = game + player;
            //game -= player; // same as game = game - player;

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPLayers();
            //Console.ReadLine();

            //TwentyOneGame object morphing into a Game object
            //Game game = new TwentyOneGame();

            //Inheritance and calling method ListPlayers////////////
            //TwentyOneGame game = new TwentyOneGame();
            ////calling super class method, "game"
            //game.Players = new List<string>() { "Lizzy", "Bill", "Joe" };
            //game.ListPLayers();
            //game.Play();
            //Console.ReadLine();
            ////creating object:deck
            //Deck deck = new Deck();

            //Lambda function is "Count", "Cards" is a list
            //"x" is standard and represents each element in the list
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);


            ///Another lambda example////
            //"Where" is a lambda function where you can filter your list for particular features- must have "ToList" to work
            //Says: take a list of cards + findout where the "Face" equals the "King" + map that to a new list
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}


            ////Another lambda example with new list and instantiating w/ values////
            /////fast way to sum numbers in a list--- output should be 906 w/ (int sum = numberList.Sum())
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            //additional arithmetic to each item in the list.
            //says; for each item, lets add "5" to that item
            //output should now go from 906 to 936 with additional arithmetic
            //int sum = numberList.Sum(x => x + 5);

            //Console.WriteLine(sum);
            
            
            
            ////Shuffling deck example////
            //calling method to shuffle deck 3x, sending it out + assigning variable timesShuffled
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
        //    Console.ReadLine();
        //}
        
        
        //Enums example//
        //public enum DaysofTheWeek
        //{
        //    Monday, 
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday

        //}



    }
}
