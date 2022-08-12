using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_SubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //using polymorphism, creating object

            List<Person> persons = new List<Person>();
            Employee employee = new Employee();
            employee.middleName = "Sample";
            employee.Quit(employee);

            Console.ReadLine();







            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
