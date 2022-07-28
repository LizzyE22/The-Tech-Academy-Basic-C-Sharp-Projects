using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            //user input person 1 hourly rate//
            string askRateP1 = Console.ReadLine();
            decimal rateAnswerP1 = Convert.ToDecimal(askRateP1);
            Console.WriteLine("How many hours worked per week?");
            //user input person 1 hours per week//
            string askHoursP1 = Console.ReadLine();
            decimal hoursAnswerP1 = Convert.ToDecimal(askHoursP1);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            //user input person 2 hourly rate//
            string askRateP2 = Console.ReadLine();
            decimal rateAnswerP2 = Convert.ToDecimal(askRateP2);
            Console.WriteLine("How many hours worked per week?");
            //user input person 2 hours per week//
            string askHoursP2 = Console.ReadLine();
            decimal hoursAnswerP2 = Convert.ToDecimal(askHoursP2);

            Console.WriteLine("Annual salary of Person 1: ");
            //multiply person 1 hourly rate * hours worked//
            decimal totalP1 = rateAnswerP1 * hoursAnswerP1;
            Console.WriteLine(totalP1);

            Console.WriteLine("Annual salary of Person 2: ");
            //multiply person 2 hourly rate * hours worked//
            decimal totalP2 = rateAnswerP2 * hoursAnswerP2;
            Console.WriteLine(totalP2);

            //boolean result if person 1 makes more than person 2//
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool trueOrFalse = totalP1 > totalP2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
