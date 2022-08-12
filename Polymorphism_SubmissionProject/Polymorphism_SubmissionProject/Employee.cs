using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_SubmissionProject
{
    //class Employee inherits from class Persons
    //class Employee inherits from interdface IWalkAway
    public class Employee : Person, IQuittable
    {
        //implementing SayName() method inside Employee class
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        //Employee class implementing Quit() method
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
            
        }
    }
}
