using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne_Game
{
    public class TwentyOneRules
    {
        //private means it will only be accessed inside this class
        //naming convention in private classes is to use an underscore ahead of it(_cardValues)
        // creating a dictionary(collection of name value pairs) of all their cards and values
        //to quickly look up what the value of a card is in our methods and calculate the value of a hand
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        //instantiating with all the objects
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        //this method will return an integer array
        //pass in a Hand and it returns an array of integers
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //this method will return an integer array of the possible values
            //finding out how many aces there are using Lambda expression
            //Lambda: for each item, is the cards face equivalent to an Ace?
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            //creating result as an integer array- arrays must state how big its going to be(how many possible results are there?)
            int[] result = new int[aceCount + 1];
            //takes each item, looks it up in _cardValues dictionary
            //taking card, looking up the value and sums it
            int value = Hand.Sum(x => _cardValues[x.Face]);
            //takes first entry in integer array and assigning value to it
            result[0] = value;
            //no curly braces needed for if statement if just on one line
            if (result.Length == 1) return result;

            for (int i = 1; i < result.Length; i++)
            {
                //shorthand for value = value + (i *10);
                value += (i * 10);   //value is the lowest possible value(all Aces = 1)
                result[i] = value;
            }
            return result;
        }

        //this method will return true or false if the hand is blackjack(ace and a face card)
        //passed in the list of Cards called Hand
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            //creating int array of possible values
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();   //getting max possible value
            if (value == 21) return true;
            else return false;
        }
        //creating method to see if player busts/over 21
        public static bool IsBusted(List<Card> Hand)    //static method, no need to create an object
        {
            int value = GetAllPossibleHandValues(Hand).Min();   //getting value of the hand/ pass in Hand/ Lambda expression for min value
            if (value > 21) return true;
            else return false;
        }

        //creating static method, passing card with a hand
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)   //dealer should stay
                {
                    return true;
                }
            }
            return false;
        }        
        
        //this method returns a nullable boolean 
        //taking in 2 parameters; PlayerHand, DealerHand
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            //int arrays of all possible player and dealer results
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);
            //takes items in playerResults and filters them
            //gives a list of playerResults where int is less than 22 and the largest value
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;

        }
    }
}
