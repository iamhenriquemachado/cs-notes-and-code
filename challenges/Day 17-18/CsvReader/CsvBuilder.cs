using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Exceptions;
using cs_notes_and_code.challenges.CsvReader.Interfaces;
using System.Globalization;


namespace cs_notes_and_code.challenges.CsvReader
{
    internal class CsvBuilder : ICar
    {
        private List<Car> _records = new List<Car>();
        string filePath = @"C:\Users\heyhe\development\cs-notes-and-code\challenges\Day 17-18\CsvReader\Files\entity.csv";
        public void Add(List<Car> cars)
        {
            if (cars == null) throw new ArgumentNullException("The list cannot be null...");
            try
            {
                Console.WriteLine("Inserting new cars on the list");
                foreach (var car in cars)
                {
                    if (car.Year < 2000)
                    {
                        throw new CsvInvalidException(message: $"Cannot insert a new card record before 2000.", violatingValue: car.Year, ruleName: 101);
                    }
                }
                using (var writer = new StreamWriter(filePath, true))
                using (var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    if (new FileInfo(filePath).Length == 0)
                    {
                        csv.WriteHeader<Car>();
                        csv.NextRecord();
                    }
                    foreach (var car in cars)
                    {
                        csv.WriteRecord(car);
                        csv.NextRecord();
                    }
                    _records.AddRange(cars);
                    Console.WriteLine($"Records inserted on the list... {_records.Count()}");

                }
            }
            catch (CsvInvalidException e)
            {
                Console.WriteLine($"CSV invalid exception: {e.ViolatingValue}");
            }
        }
        public void DeleteById(int id)
        {


            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
                {

                    var result = csv.GetRecords<Car>().ToList();


                    if (result != null)
                    {
                        var carIdFound = result.FirstOrDefault(car => car.Id == id);

                        if (carIdFound.Id == null)
                        {
                            throw new ArgumentException("Id does not exists.");
                        }

                        else if (carIdFound != null)
                        {
                            result.Remove(carIdFound);
                            _records = result;
                        }
                    }
                }

                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(_records);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IReadOnlyList<Car> List()
        {
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var result = csvReader.GetRecords<Car>().ToList();
                return result;
            }
        }
        public void SearchById(int id)
        {
            throw new NotImplementedException();
        }
    }
}