using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();

            List<string>Things1 = new List<string>() { "Thing1", "Thing2", "Thing3" };
            List<int>Things2 = new List<int>() { 2, 4, 6, 8, 10 };


            foreach (var x in Things1)
            {
                Console.WriteLine(x);

            }
            foreach (var x in Things2)
            {
                    Console.WriteLine(x);

            }
                Console.ReadLine();
        }
    }
}
