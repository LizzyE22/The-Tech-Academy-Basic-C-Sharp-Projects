using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string askAge = Console.ReadLine();
            int ageAnswer = Convert.ToInt32(askAge);

            Console.WriteLine("Have you ever had a DUI? Answer True or False.");
            string askDUI = Console.ReadLine();
            bool duiAnswer = Convert.ToBoolean(askDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string askTickets = Console.ReadLine();
            int ticketAnswer = Convert.ToInt32(askTickets);

            Console.WriteLine("Qualified?");
            bool qualified = Convert.ToBoolean(ageAnswer > 15 && duiAnswer == false && ticketAnswer <= 3);
            Console.WriteLine(qualified);

            Console.ReadLine();


        }
    }
}
