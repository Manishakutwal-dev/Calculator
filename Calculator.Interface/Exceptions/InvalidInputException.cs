using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Interface.Exceptions
{
    public class InvalidInputException : Exception
    {   
        public InvalidInputException(string message) : base(message)
        {
            
        }
    }
}
