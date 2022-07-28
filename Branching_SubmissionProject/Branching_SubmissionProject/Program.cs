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
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight");
            string askWeight = Console.ReadLine();
            decimal weightAnswer = Convert.ToDecimal(askWeight);
            if (weightAnswer > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
            }
            Console.WriteLine("Please enter the package width:");
            string askWidth = Console.ReadLine();
            decimal widthAnswer = Convert.ToDecimal(askWidth);

            Console.WriteLine("Please enter the package height:");
            string askHeight = Console.ReadLine();
            decimal heightAnswer = Convert.ToDecimal(askHeight);

            Console.WriteLine("Please enter the package length:");
            string askLength = Console.ReadLine();
            decimal lengthAnswer = Convert.ToDecimal(askLength);
            if (widthAnswer + heightAnswer + lengthAnswer > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            decimal totalDimension = widthAnswer * heightAnswer * lengthAnswer * weightAnswer / 100;
            //decimal dimensionAnswer = Convert.ToDecimal(totalDimension);
            //Console.WriteLine("$" + dimensionAnswer);
            Console.WriteLine("$" + totalDimension);
            Console.WriteLine("Thank you!");


            Console.ReadLine();
            }
        }
    }

