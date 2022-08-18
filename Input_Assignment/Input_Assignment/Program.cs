using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:Users\Esque\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Input_Assignment\log.txt", true))
            {
                file.WriteLine(userNumber);

            }
            Console.ReadLine();

        }
    }

}
