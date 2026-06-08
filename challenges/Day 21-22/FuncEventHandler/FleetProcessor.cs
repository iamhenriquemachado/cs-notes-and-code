using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                foreach (var item in rawData)
                {
                    var splittedList = item.Split(',');

                    if (splittedList.Length < 5)
                    {
                        throw new ArgumentNullException("List is corrupted");
                    }

                    _parser.ParseLine(item);

                    var normalizeYear = Int32.TryParse(splittedList[2], out int year);
                    var normalizeMileage = Int32.TryParse(splittedList[3], out int mileage);
                    var normalizeStatus = bool.TryParse(splittedList[4], out bool status);

                    Vehicle vehicle = new Vehicle()
                    {
                        Brand = splittedList[0],
                        Model = splittedList[1],
                        Year = year,
                        Mileage = mileage,
                        Active = status
                    };

                    _vehicles.Add(vehicle);
                }
            }
            catch (InvalidVehicleDataException e)
            {

                Console.WriteLine($"Message: {e.RawLine} / Validatio Rule: {e.ValidationRule}");
            }

        }
    }
}