using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathAndComparisonOperators
    {
        class Program
        {
            static void Main(string[] args)
            {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //Remainder of 2 numbers:
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //Comparison Operator
            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //Step 185 in c#; Console app assignment #1, takes input from user and multiplies by 50 //
            Console.WriteLine("Choose a number and we'll multiply it by 50");
            int askNumber = Convert.ToInt32(Console.ReadLine());
            int product = askNumber * 50;
            Console.WriteLine(product);
            Console.ReadLine();
            
            //#2, takes input from user and adds 25//
            Console.WriteLine("Choose a number and we'll add 25 to it");
            int addNumber = Convert.ToInt32(Console.ReadLine());
            int total = addNumber + 25;
            Console.WriteLine(total);
            Console.ReadLine();
            
            //#3, takes input from user and divides by 12.5//
            Console.WriteLine("Choose a number to divide by 12.5");
            int divideNumber = Convert.ToInt32(Console.ReadLine());
            int quotient= (int)(divideNumber / 12.5);
            Console.WriteLine(quotient);
            Console.ReadLine();
            
            //#4, takes input from user and checks if greater than 50//
            Console.WriteLine("Is the number you enter greater than 50?");
            int userNumber = Convert.ToInt32(Console.ReadLine()); 
            bool trueOrFalse = userNumber > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
            
            //#5, takes input from user and divides by 7 with remainder//
            Console.WriteLine("Divide your number by 7 with a remainder");
            int enterNumber = Convert.ToInt32(Console.ReadLine());
            int remainder = enterNumber % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();


        }
    }
 }

