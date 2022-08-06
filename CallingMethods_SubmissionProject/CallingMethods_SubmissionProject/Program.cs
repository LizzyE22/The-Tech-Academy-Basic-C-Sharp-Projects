using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
         
        {
            //Requesting number for user input to apply Math
            Console.WriteLine("What number would you like to do some Math with?");
            string askNumber = Console.ReadLine();
            int userNumber = Convert.ToInt32(askNumber);


            Class1 class1 = new Class1();
            //calling methods in Class1

            int Number1 = class1.Add(userNumber);
            int Number2 = class1.Add2(userNumber);
            int Number3 = class1.Add3(userNumber);

            Console.WriteLine(Number1);
            Console.WriteLine(Number2);
            Console.WriteLine(Number3);
            Console.ReadLine();

        }
    }   
}
