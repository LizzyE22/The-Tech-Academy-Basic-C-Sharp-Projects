using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_SubmissionProject
{
    public abstract class Person
    {
        //abstract class with 2 properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }

        public abstract void SayName();


    }
}
