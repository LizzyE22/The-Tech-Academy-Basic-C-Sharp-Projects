using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_SubmissionAssignment
{
    public class Employee
    {
        public int EmployeeWage { get; set; }
        public string Name { get; set; }

        //chaining 2 constructors together
        public Employee(string name) : this(name, 25)
        {

        }
        public Employee(string name, int wage)
        {
            EmployeeWage = wage;
            Name = name;
        }
       
    }
}
