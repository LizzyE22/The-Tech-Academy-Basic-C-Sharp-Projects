using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_SubmissionAssignment
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        //overloaded == operator method
        //changing from string to bool operator
        public static bool operator == (Employee employee1, Employee employee2)

        {
            //checking if objects are equal by comparing Id property
            return employee1.Id == employee2.Id;

        }
        public static bool operator != (Employee employee1, Employee employee2)
        {
            //checking if objects are not equal by comparing Id property
            return employee1.Id != employee2.Id;

        }





    }
}
