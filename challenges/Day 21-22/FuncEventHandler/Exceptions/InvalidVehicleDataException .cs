using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler.Exceptions
{
    internal class InvalidVehicleDataException : Exception
    {
        public string RawLine { get; set; }
        public string ValidationRule { get; set; }

        public InvalidVehicleDataException(string message) : base(message) { }

        public InvalidVehicleDataException(string rawLine, string validationRule, string message) : base($"Message: {message} | Validation Rule Broken: {validationRule}")
        {
            RawLine = rawLine;
            ValidationRule = validationRule;

        }
    }
}
