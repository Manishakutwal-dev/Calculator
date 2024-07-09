using Calculator.Interface.Exceptions;
using Calculator.Main.Entities;
using Calculator.DBContext;
using org.matheval;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interface.Services.Implementation
{
    public class CalculatorService : ICalculatorService
    {       
        public async Task<double> Evaluate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new InvalidInputException("Input shoule not be empty");
            }
            try
            {
                Expression e = new Expression(input);
                var value = e.Eval();
                return Convert.ToDouble(value);
            }
            catch (Exception)
            {
                throw new InvalidInputException("Input is not valid");
            }
        }
    }
}
