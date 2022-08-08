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



            Class1 class1 = new Class1();

            int Answer1 = class1.Addition(Number);
            int Answer2 = class1.Addition(Number);
            int Answer3 = class1.Addition(Number);

            Console.WriteLine(Answer1);
            Console.WriteLine(Answer2);
            Console.WriteLine(Answer3);

            Console.ReadLine();
        }
    }
}
