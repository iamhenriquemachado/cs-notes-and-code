using cs_notes_and_code.challenges.Day_21_22.FuncEventHandler.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler
{
    internal class VehicleParser : IVehicleParser
    {

        public Vehicle ParseLine(string rawLine)
        {
            if (string.IsNullOrEmpty(rawLine))
            {
                throw new ArgumentNullException(nameof(rawLine), "Line cannnot be null.");
            }

            string[] columns = rawLine.Split(',');

            if (columns.Length != 5)
            {
                throw new InvalidVehicleDataException(
                    rawLine = rawLine,
                    message: "Row structure is invalid. Expected 4 comma-separated colums.",
                    validationRule: "LINE CANNOT BE NULL OR EMPTY"
                 );
            }

            try
            {
                return new Vehicle
                {
                    Brand = columns[0], 
                    Model = columns[1], 
                    Year = int.Parse(columns[2].Trim()),
                    Mileage = int.Parse(columns[3].Trim()), 
                    Active = bool.Parse(columns[4].Trim())
                };
            }
            catch (FormatException e)
            {

                throw new InvalidVehicleDataException(
                    message: "Failed to parse numeric data type fields.", rawLine: rawLine, validationRule: "DataTypeMismatch");
            }
        }
    }
}
