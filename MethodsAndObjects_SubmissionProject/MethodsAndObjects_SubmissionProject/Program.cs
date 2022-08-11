using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects_SubmissionProject
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //instantiating and initializing an Employee object with FirstName and LastName
            Employee employee = new Employee();
            employee.FirstName ="Sample";
            employee.LastName = "Student";
            //calling superclass method SayName() on Employee object
            employee.SayName();
                   
        }
    }
}



