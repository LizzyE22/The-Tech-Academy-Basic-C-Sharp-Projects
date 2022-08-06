using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionProject
{
    public class Class1
    {
        public int Addition(int Number)
        {
            int result = Number + 100;
            return result;
        }
        public int Addition(decimal Number)
        {
            int result = Convert.ToInt32(Number + 200);
            return result;
        }
        public int Addition(string Number)
        {
            int result = Convert.ToInt32(Number + 300);
            return result;
        }
        
    }
}
