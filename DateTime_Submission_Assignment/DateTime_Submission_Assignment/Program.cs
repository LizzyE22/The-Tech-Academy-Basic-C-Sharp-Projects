using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Submission_Assignment
{
    public class Program
    {
        public static void Main(string[] args)

        {
       
            //public DateTime AddHours(double value);

            DateTime dateTime = DateTime.Now;
            //printing current date and time
            Console.WriteLine(dateTime);
            
            //asking user input for number 
            Console.WriteLine("Please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            //printing exact time it will be in hours with user input snumber 
            DateTime newTime = dateTime.AddHours(userNumber);
            Console.WriteLine(newTime);
            Console.Read();
        }
    }
}
