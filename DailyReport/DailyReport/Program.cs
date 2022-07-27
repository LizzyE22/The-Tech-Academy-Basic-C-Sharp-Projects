using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro to daily report//
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //The following are questions for the user//
            Console.WriteLine("What is your name?");
            string askName = Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string askCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string askPage = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            string askHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to provide? Please be specific.");
            string askExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string askFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string askHours = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
               
   
            Console.ReadLine();


        }
    }
}
