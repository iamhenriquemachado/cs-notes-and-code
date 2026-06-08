using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler
{
    internal class FleetProcessor : IVehicleParser
    {

        public void RawDataParser(string[] rawData)
        {

            foreach (var item in rawData)
            {
                var splittedList = item.Split(',');

                var normalizeYear = Int32.TryParse(splittedList[2], out int year);
                var normalizeMileage = Int32.TryParse(splittedList[3], out int mileage);
                var normalizeStatus = bool.TryParse(splittedList[4], out bool status);

                List<Vehicle> vehicleList = new()
                {
                    new Vehicle
                    {
                        Brand = splittedList[0],
                        Model = splittedList[1],
                        Year = year,
                        Mileage = mileage,
                        Active = status
                    }
                };
            }
        }
    }
}