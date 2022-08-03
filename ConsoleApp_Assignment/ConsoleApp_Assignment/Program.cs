using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////Console App; Part 1 assignment///////////////
            //string[] strArray = { "Who doesn't love a ", "One of the most beautiful flowers is a ", "I love the smell of a fresh " };

            //Console.WriteLine("Tell us your favorite flower!");
            //string askFlower = Console.ReadLine();

            //foreach( string i in strArray)
            //{
            //    Console.WriteLine(i + askFlower);
            //}
            //foreach (string i in strArray)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            /////////////Console App; Part 2 assignment//////////////

            //Console.WriteLine("Guess how many countries are in Europe");
            //int countries = Convert.ToInt32(Console.ReadLine());
            ////Correct answer is 44//
            //bool isGuessed = countries == 44;
            //do
            //{
            //    switch (countries)
            //    {
            //        case 20:
            //            Console.WriteLine("20 is incorrect. Guess again!");
            //            countries = Convert.ToInt32(Console.ReadLine());
            //            //break code is used to break out of an infinite loop//
            //            break;
            //        case 30:
            //            Console.WriteLine("30 is incorrect. Guess again!");
            //            countries = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 35:
            //            Console.WriteLine("35 is incorrect. Guess again!");
            //            countries = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 40:
            //            Console.WriteLine("40 is incorrect, but you're super close. Guess again!");
            //            countries = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 44:
            //            Console.WriteLine("44 is correct! Nice job!");
            //            isGuessed = true;
            //            break;
            //        //if no case is true, this default displays//
            //        default:
            //            Console.WriteLine("Nope, try again!");
            //            Console.WriteLine("Guess how many coutries are in Europe");
            //            countries = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            ////while loop//
            //while (!isGuessed);
            //Console.Read();

            ////////////////////Console App; Part 3 assignment////////////////
            //int tankTemp = 85;

            //Console.WriteLine("What is the current temperature in the winery?");
            //string askTemp = Console.ReadLine();
            //int currentTemp = Convert.ToInt32(askTemp);

            //////if/else statement//
            ////if (currentTemp == tankTemp)
            ////{
            ////    Console.WriteLine("Tank temp and winery temp are the same. Adjust tank to the required temperature above room temp.");
            ////}
            //if (tankTemp < currentTemp)
            //{
            //    Console.WriteLine("Winery temp is currently warmer than tank temperature. Adjust tank to the required temperature above room temp.");
            //}
            //else if (tankTemp <= currentTemp)
            //{
            //    Console.WriteLine("Winery temp is either equal to or greater than tank temp. Adjust tank to the required temperature above room temp");
            //}
            //else
            //{
            //    Console.WriteLine("Tank temp is warmer than winery temp- no adjustment needed");
            //}
            //Console.ReadLine();

            ////////////////Console App; Part 4 assignment////////////////

            List<string> dogList = new List<string>();
            dogList.Add("Golden Retriever");
            dogList.Add("Labrador");
            dogList.Add("Aussie Shepherd");
            dogList.Add("Maltese");

            Console.WriteLine("Type in your favorite kind of dog to see if it's on our list!");
            string dogAnswer = Console.ReadLine();

            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList[i] == dogAnswer)
                {
                    Console.WriteLine("You chose a dog on our list: " + dogList[i]);
                }
                else 
                {
                    Console.WriteLine("A match was not found for your entry. Try again!");
                    dogAnswer = (Console.ReadLine());
                }
            }
            Console.ReadLine();





















            //if (dogAnswer == "Golden Retriever")
            //{
            //    Console.WriteLine("You chose a dog on our list: " + dogList[0]);
            //}
            //if (dogAnswer == "Labrador")
            //{
            //    Console.WriteLine("You chose a dog on our list: " + dogList[1]);
            //}
            //if (dogAnswer == "Aussie Shepherd")
            //{
            //    Console.WriteLine("You chose a dog on our list: " + dogList[2]);
            //}
            //if (dogAnswer == "Maltese")
            //{
            //    Console.WriteLine("You chose a dog on our list: " + dogList[3]);
            //}
            //else 
            //{
            //    Console.WriteLine("You selected a dog not on our list. Try again!");
            //    Console.WriteLine("Type in your favorite kind of dog to see if its on our list!");
            //    dogAnswer = (Console.ReadLine());
            //}

            //Console.ReadLine();


        }
    }
}
    

    

