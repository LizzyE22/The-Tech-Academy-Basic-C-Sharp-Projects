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
            Console.WriteLine("What number would you like to do Math with?");
            string askNumber = Console.ReadLine();
            int userNumber = Convert.ToInt32(askNumber);

            Class1 class1 = new Class1();
            //method
            class1.Num1 = 10;
            class1.Num2 = 20;

            Console.WriteLine(class1.Num1 + class1.Num2);
            Console.ReadLine();

            class1.Num1 = 30;
            class1.Num2 = 40;

            Console.WriteLine(class1.Num1 * class1.Num2);
            Console.ReadLine();

            class1.Num1 = 60;
            class1.Num2 = 20;
            Console.WriteLine(class1.Num1 / class1.Num2);
            Console.ReadLine();

        }
    }
}
