using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_SubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////creating a constant variable
            //const string wineChardonnay = "lemon notes, tree fruit including green apple, and great minerality";
            //Console.WriteLine("This Chardonnay has {0}", wineChardonnay);
            //Console.ReadLine();

            ////creating variable with keyword "var"
            //var dic = new Dictionary<string, Dictionary<int, string>>();

            //chaining 2 contructors together example
            Employee newEmployee = new Employee("Lizzy");
            Console.WriteLine(newEmployee);
            Console.ReadLine();
        }
    }
}
