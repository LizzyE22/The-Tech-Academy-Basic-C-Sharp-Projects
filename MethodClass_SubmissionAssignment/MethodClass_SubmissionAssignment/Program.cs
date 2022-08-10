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

            NewClass newClass = new NewClass();
            NewClass.Answer(2, 4);
            NewClass.Answer(Number1, Number2);
        }           
    }
}
