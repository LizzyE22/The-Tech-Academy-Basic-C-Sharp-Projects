using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //creating 2 constructors, one overloading the other
    //having them implement the exact same implementation that exists for exception
    public class FraudException : Exception
    {
        public FraudException()     //standard constructor inherited from base exception
            : base() { }
        public FraudException(string message)
            : base(message) { }

    }
}
