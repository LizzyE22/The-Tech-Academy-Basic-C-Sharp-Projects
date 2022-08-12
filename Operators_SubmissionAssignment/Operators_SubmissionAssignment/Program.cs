using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_SubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating objects
            Employee employee = new Employee();
            employee.FirstName = "Lizzy";
            employee.LastName = "Esqueda";

            Console.WriteLine(employee.FirstName + " " + employee.LastName);
            Console.ReadLine();
        }
    }
}
