using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CsvReader.Exceptions
{
    internal class CsvInvalidException : Exception
    {
        public int ViolatingValue { get; set; }
        public int RuleName { get; set; }

        public CsvInvalidException(string message) : base(message) { }

        public CsvInvalidException(string message, int violatingValue, int ruleName) : base($"{message} (Value violated at: {violatingValue}")
        {
            ViolatingValue = violatingValue;
            RuleName = ruleName;
        }

    }
}
