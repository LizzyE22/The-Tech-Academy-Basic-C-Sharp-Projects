using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());
            string askNumber = Console.ReadLine();
            //string Answer3 = Convert.ToInt32((askNumber));

            Class1 class1 = new Class1();

            int Answer1 = class1.Addition(Number);
            decimal Answer2 = class1.Addition2(Number);
            int Answer3 = class1.Addition3(Number);

            Console.WriteLine(Answer1);
            Console.WriteLine(Answer2);
            Console.WriteLine(Answer3);

            Console.ReadLine();
        }
    }
}
