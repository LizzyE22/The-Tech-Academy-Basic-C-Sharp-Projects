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
            
            Class1 class1 = new Class1();

            int Answer1 = class1.Addition(100);
            int Answer2 = class1.Addition(2.4m);
            int Answer3 = class1.Addition(25);

            Console.WriteLine(Answer1);
            Console.WriteLine(Answer2);
            Console.WriteLine(Convert.ToInt32(Answer3));

            Console.ReadLine();
        }
    }
}


