using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using cs_notes_and_code.challenges.Day_21_22;
using cs_notes_and_code.challenges.Day_21_22.FuncEventHandler.Events;
using cs_notes_and_code.challenges.Day_21_22.FuncEventHandler.Exceptions;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler
{
    internal class FleetProcessor

    {
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private readonly IVehicleParser _parser;
        private readonly IFleetLogger _logger;
        public event EventHandler<ProcessingProgressEventArgs> ProgressChanged;

        public FleetProcessor(IVehicleParser parser, IFleetLogger logger)
        {
            _parser = parser;
            _logger = logger;
        }

        public void ProcessRawPayload(string[] rawData)
        {
            for (int i = 0; i < rawData.Length; i++)
            {
                try
                {
                    var parsedData = _parser.ParseLine(rawData[i]);

                    int percentage = ((i + 1) * 100) / rawData.Length;
                    string batchName = rawData[i];

                    OnProgressChanged(percentage, batchName);
                }
                catch (FormatException)
                {

                    throw new InvalidVehicleDataException(
                    message: "Failed to parse numeric data type fields.", 
                    rawLine: rawData[i], 
                    validationRule: "DataTypeMismatch");
                }
            }

        }

        protected virtual void OnProgressChanged(int percentage, string batch)
        {
            ProgressChanged?.Invoke(this, new ProcessingProgressEventArgs(percentage, batch));
        }
    }
}