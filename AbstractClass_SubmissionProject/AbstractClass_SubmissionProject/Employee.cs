using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_SubmissionProject
{
    //class Employee inherits from class PersonS
    public class Employee : Person
    {
        //implementing SayName() method inside Employee class
        public override void SayName()
        {
            Console.WriteLine(firstName  + " " + lastName);
        }
    }
}
