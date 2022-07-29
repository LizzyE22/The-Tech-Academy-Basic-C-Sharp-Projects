using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program requesting user to guess how many seasons of the Simpsons there are//
            Console.WriteLine("Take a guess how many seasons of the Simpsons there are!");
            int seasons = Convert.ToInt32(Console.ReadLine());
            //Correct answer is 33//
            bool isGuessed = seasons == 33;
            //do while loop ahead and before the while loop hits//
            do
            {
                switch (seasons)
                {
                    case 10:
                        Console.WriteLine("You guessed 10. Guess again!");
                        Console.WriteLine("Guess how many seasons?");
                        seasons = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You guessed 20. Guess again!");
                        Console.WriteLine("Guess how many seasons?");
                        seasons = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 25:
                        Console.WriteLine("You guessed 25. Guess again!");
                        Console.WriteLine("Guess how many seasons?");
                        seasons = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("So close! You guessed 30. Guess again!");
                        Console.WriteLine("Guess how many seasons?");
                        seasons = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 35:
                        Console.WriteLine("So close! You guessed 35. Guess again!");
                        Console.WriteLine("Guess how many seasons?");
                        seasons = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 33:
                        Console.WriteLine("You guessed 33! That's correct! There are 33 seasons so far. Nice work.");
                        isGuessed = true;
                        break;
                    //if no cases evaluate to true, this default pops up//
                    default:
                        Console.WriteLine("Nope, try again!");
                        Console.WriteLine("Guess how many seasons?");
                        seasons = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            //while loop//
            while (!isGuessed);

            Console.Read();
        }
    }
}
