using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_26_27_Architectural_Structure.Exceptions
{
    internal class InsufficientStockException : Exception
    {
        public int ViolatingRule { get; set; }
        public int RowLine { get; set; }

        public InsufficientStockException(string message) : base(message) { }

        public InsufficientStockException(string message, int violatingValue, int rowLine) : base($"Message: {message} | Violated Rule: {violatingValue}")
        {
            ViolatingRule = violatingValue;
            RowLine = rowLine;
        }

    }
}
