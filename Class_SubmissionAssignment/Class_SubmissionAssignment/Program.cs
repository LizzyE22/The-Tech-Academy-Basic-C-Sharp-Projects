using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_SubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            //instantiating class
            NewClass newClass = new NewClass();
            //calling method on the user input number
            NewClass.Answer(Num1);
            Console.WriteLine(Num1);
            Console.ReadLine();

        }

        //method overloading
        //method with 2 parameters(one output parameter)
        public static void MyMethod(int param1, out int param2)
        {
            Console.WriteLine("Enter the 1st value");
            param1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            param2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
        //method with 3 parameters
        public static void MyMethod(int param1, int param2, int param3)
        {
            Console.WriteLine(param3);
            Console.ReadLine();

        }

        //declaring a class to be static 
        static class Info
        {
            public static void SayHi(string name)
            {
                Info.SayHi("Lizzy");
                Console.ReadLine();
            }
        }




    }
}
