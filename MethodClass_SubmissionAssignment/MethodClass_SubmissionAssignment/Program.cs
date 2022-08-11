using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass_SubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Number1 = 2;
            int Number2 = 4;

            //instantiating class
            NewClass newClass = new NewClass();
            //calling class, passing in 2 numbers
            NewClass.Answer(2, 4);
            //calling class specifying parameters by name
            NewClass.Answer(Number1, Number2);
        }           
    }
}
