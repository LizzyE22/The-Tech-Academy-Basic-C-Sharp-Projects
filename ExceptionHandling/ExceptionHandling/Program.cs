using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
            ////////Try/Catch Block//////////////
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            //only catching a Format Exception and assigning it variable "ex"
            catch(FormatException ex)
            {
                //Writes the error to the screen
                //Console.WriteLine(ex.Message);
                //Writing your own message
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            //creating a general exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally runs no matter what//
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
            
        }
    }
}
