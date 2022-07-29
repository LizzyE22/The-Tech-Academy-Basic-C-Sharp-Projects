using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input for package weight to be less than 50 to continue//
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight");
            string askWeight = Console.ReadLine();
            decimal weightAnswer = Convert.ToDecimal(askWeight);
            if (weightAnswer > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
            }
            
            else 
            {
                //User input for package width//
                Console.WriteLine("Please enter the package width:");
            }
            string askWidth = Console.ReadLine();
            decimal widthAnswer = Convert.ToDecimal(askWidth);
            //User input for package height//
            Console.WriteLine("Please enter the package height:");
            string askHeight = Console.ReadLine();
            decimal heightAnswer = Convert.ToDecimal(askHeight);
            //User input for package length//
            Console.WriteLine("Please enter the package length:");
            string askLength = Console.ReadLine();
            decimal lengthAnswer = Convert.ToDecimal(askLength);
            //Calculating total weight of dimensions to be less than 50 to continue//
            if (widthAnswer + heightAnswer + lengthAnswer > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                //Multiplying dimensions by weight and dividing by 100 for total displayed in dollar amount//
                decimal totalDimension = widthAnswer * heightAnswer * lengthAnswer * weightAnswer / 100;
                Console.WriteLine("$" + totalDimension);
                Console.WriteLine("Thank you!");
            }


            //decimal dimensionAnswer = Convert.ToDecimal(totalDimension);
            //Console.WriteLine("$" + dimensionAnswer);



            Console.ReadLine();
            }
        }
    }

