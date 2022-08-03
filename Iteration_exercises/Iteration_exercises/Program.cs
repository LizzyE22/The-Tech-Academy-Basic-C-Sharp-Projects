using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_exercises
{
    class Program
    {
        static void Main(string[] args)
        {   ////////////////////Exercise 1/////////////////////////////
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            ////display every score of 85//
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if(testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //////////////Exercise 2; displays the entire list and example of one item//////////////////////
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Jesse")
            //    Console.WriteLine(names[j]);           
            // }
            // Console.ReadLine();


            //////////////////////////Exercise 3/ForEach Loop/////////////////////////////
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);
            ////now iterating over this list, log to the console any passing score over 85 using a for/each loop//

            ////"score" is a variable that represents the item in the list which you're at//
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);

            //    }
            //}
            //Console.ReadLine();

            ////////////////////Exercise 4; ForEach Loop w/ a String/////////////////////////////
            //List <string> names = new List<string>() {  "Jesse", "Erik", "Adam", "Daniel"};

            //foreach (string name in names)
            //{
            //    //to just display Jesse; remove to print list//    
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            ////////////////Exercise 5; iterate over list; when condition is met, add to other list/////////////////
            //integer list of test scores//
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //creating a blank list//
            List<int> passingScores = new List<int>();
            //foreach loop 
            foreach (int score in testScores)
            {
                //loop test scores, each that passes, add it to passing score//
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            //showing how many passing scores there were//
            //"count" in a list is the same as "length" in an array//
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
            }
        }
    }

