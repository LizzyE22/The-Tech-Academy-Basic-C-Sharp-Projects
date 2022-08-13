using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_SubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //prompting user entry
                //assigning value to variable of enum data type
                Console.WriteLine("Please enter the current day of the week.");
                string currentday = Console.ReadLine();
                days day;

                if (Enum.TryParse<days>(currentday, out day))
                {
                    Console.WriteLine("Nice job!  Today is " + currentday);
                    Console.ReadLine();
                }
                else
                {
                    throw new OverflowException(); //throwing Overflow Exception
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }


        //Enum for days of the week
        public enum days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}








       
