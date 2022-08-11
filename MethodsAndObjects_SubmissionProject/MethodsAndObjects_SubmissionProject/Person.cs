using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects_SubmissionProject
{
    public class Person
    {
        //giving class Person 2 properties of data type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //void method "SayName()" with no parameters
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
            Console.ReadLine();
        }
    }
}
