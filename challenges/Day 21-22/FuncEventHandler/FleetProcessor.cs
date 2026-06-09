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
            _logger.LogInfo("Process started.");

            for (int i = 0; i < rawData.Length; i++)
            {
                try
                {
                    var parsedData = _parser.ParseLine(rawData[i]);
                    _vehicles.Add(parsedData);

                    int percentage = ((i + 1) * 100) / rawData.Length;
                    string batchName = rawData[i];

                    OnProgressChanged(percentage, batchName);
                }
                catch (FormatException)
                {
                    _logger.LogWarning("List was created.");

                    throw new InvalidVehicleDataException(
                        message: "Failed to parse numeric data type fields.",
                        rawLine: rawData[i],
                        validationRule: "DataTypeMismatch");
                }
            }
        }

        public IEnumerable<Vehicle> GetProcessedVehicles()
        {
            return _vehicles;
        }

        public void PrintConsoleData()
        {
            var processedVehicles = GetProcessedVehicles();

            Console.WriteLine(
                $"{"Brand",-12} | {"Model",-12} | {"Year",-6} | {"Mileage",10} | {"Available",-10}");

            Console.WriteLine(
                $"{new string('-', 12)}-+-{new string('-', 12)}-+-{new string('-', 6)}-+-{new string('-', 10)}-+-{new string('-', 10)}");

            foreach (var item in processedVehicles)
            {
                Console.WriteLine(
                    $"{item.Brand,-12} | " +
                    $"{item.Model,-12} | " +
                    $"{item.Year,-6} | " +
                    $"{item.Mileage,10:N0} | " +
                    $"{item.Active,-10}");
            }
        }

        protected virtual void OnProgressChanged(int percentage, string batch)
        {
            ProgressChanged?.Invoke(
                this,
                new ProcessingProgressEventArgs(percentage, batch));
        }
    }
}