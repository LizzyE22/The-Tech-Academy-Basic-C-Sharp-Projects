using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers_Submission_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try/Catch Block
            try
            {
                List<int> numbers = new List<int>() { 20, 40, 60, 100 };

                Console.WriteLine("Pick a number to divide each number in the list by");
                string askNumber = Console.ReadLine();
                int userNumber = Convert.ToInt32(askNumber);
                //for each loop to divide user input with each item in list
                foreach (int number in numbers)
                {
                    Console.WriteLine(number / userNumber);
                }

            }
            //catching a format exception and assigning it variable "ex"
            catch(FormatException ex)
            {
                //Displays the error to the screen with personal message
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }
            //creating a general exception
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally allows it to run no matter what
            finally
            {
                Console.ReadLine();
            }






            Console.ReadLine();
        }
    }
}
