using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_SubmissionProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiating Employee objects, firstName + lastName
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //calling SayName() method on the object(s)
            employee.SayName();
            Console.ReadLine();
        }
    }
}
