using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_SubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //instantiating objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            //employee1.Id = "Lizzy";
            //employee2.Id = "Esqueda";

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
