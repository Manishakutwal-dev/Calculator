using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Main.Entities
{
   public class CalculatorHistory : BaseEntity
    {
        public bool Succeeded { get; set; }
        public string ErrorMessage { get; set; }
        public string Input { get; set; }
        public double Result { get; set; }
        public DateTime? EvaluateAt { get; set; }
        public string Email { get; set; }
    }
}
