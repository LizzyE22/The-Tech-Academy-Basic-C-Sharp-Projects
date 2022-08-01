using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_SubmissionProject
{
    class Program
    {
        static void Main()
        {
            //One-dimensional string array, displaying users selection at that index with if loop//
            string[] strArray = { "Red", "Yellow", "Green", "Blue" };

            Console.WriteLine("Pick a number 0-3 to find out your lucky color!");
            string askIndex = Console.ReadLine();
            int indexAnswer = Convert.ToInt32(askIndex);

            if (indexAnswer == 0)
            {
                Console.WriteLine("Red");
            }
            if (indexAnswer == 1)
            {
                Console.WriteLine("Yellow");
            }
            if (indexAnswer == 2)
            {
                Console.WriteLine("Green");
            }
            if (indexAnswer == 3)
            {
                Console.WriteLine("Blue");
            }
            //message when user selects an index that does not exist//
            else if (indexAnswer > 3)
            {
                Console.WriteLine("You selected an index that doesn't exist.");
            }
            //One-dimensional integer array, displaying integer at that index with if loop//
            int[] intArray = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Pick a number 0-4 to see that number multiplied by 100");
            string askNumber = Console.ReadLine();
            int numberAnswer = Convert.ToInt32(askNumber);

            if (numberAnswer == 0)
            {
                Console.WriteLine("0");
            }
            if (numberAnswer == 1)
            {
                Console.WriteLine("100");
            }
            if (numberAnswer == 2)
            {
                Console.WriteLine("200");
            }
            if (numberAnswer == 3)
            {
                Console.WriteLine("300");
            }
            if (numberAnswer == 4)
            {
                Console.WriteLine("400");
            }
            //message when user selects an index that does not exist//
            else if (numberAnswer > 4)
            {            
                Console.WriteLine("You selected an index that doesn't exist.");
                Console.ReadLine();

            }
            //List of strings, asking user to select index to display//
            List<string> countryList = new List<string>();
            countryList.Add("France");
            countryList.Add("Spain");
            countryList.Add("Italy");
            countryList.Add("Germany");
            
            Console.WriteLine("Pick a number 0-3 to see what country you're traveling to next!");
            string askCountry = Console.ReadLine();
            int countryAnswer = Convert.ToInt32(askCountry);

            if(countryAnswer == 0)
            {
                Console.WriteLine("You're going to France!");
            }
            if (countryAnswer == 1)
            {
                Console.WriteLine("You're going to Spain!");
            }
            if (countryAnswer == 2)
            {
                Console.WriteLine("You're going to Italy!");
            }
            if (countryAnswer == 3)
            {
                Console.WriteLine("You're going to Germany!");
            }




            Console.ReadLine();
        }
    }
}
