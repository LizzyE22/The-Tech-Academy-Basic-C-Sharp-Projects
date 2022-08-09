using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_SubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //user input asking to enter numbers
                Console.WriteLine("Enter two numbers, one at a time");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                int Number2 = Convert.ToInt32(Console.ReadLine());

                //instantiating class
                NewClass newclass = new NewClass();
                int Total = newclass.Answer(Number1, Number2);
                {
                    Console.WriteLine("Total: " + Total);
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Thank you!");
                return;
            }
            finally
            {
                Console.ReadLine();
            }
         }
    }
}
