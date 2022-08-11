using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_SubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //user input asking to enter numbers
            Console.WriteLine("Please enter your first number.");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to enter a second number?");
            bool answerNum2 = Convert.ToBoolean(Console.ReadLine());

            //instantiating class
            NewClass newclass = new NewClass();
            int Total = newclass.Answer(Number1);

            if (answerNum2 == true)

            {
                int Number2 = Convert.ToInt32(Console.ReadLine());
                newclass.Answer(Number1, Number2);

                //Console.WriteLine(Number1, Number2);
                Console.ReadLine();
            }

            else 
            {

                newclass.Answer(Number1);
                Console.ReadLine();

            }
        }
    }

}
