using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 20, 40, 60, 100 };

            Console.WriteLine("Pick a number to divide each number in the list by");
            string askNumber = Console.ReadLine();
            int userNumber = Convert.ToInt32(askNumber);
            Console.ReadLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number / userNumber);
            }
            

            


            Console.ReadLine();
        }
    }
   
}

