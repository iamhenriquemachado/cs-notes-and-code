using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Exceptions;
using cs_notes_and_code.challenges.CsvReader.Interfaces;
using cs_notes_and_code.challenges.GenericsMemoryRepository;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CsvReader
{
    internal class CsvBuilder : ICar
    {

        private readonly List<Car> _carList = new List<Car>();

        public void Add(List<Car> cars)
        {

            // Implementing Guard Clauses before the method running
            if (cars.Count == 0) throw new ArgumentException("The list is empty...");
            if (cars == null) throw new InvalidOperationException("Cannot process a null list...");

            foreach (var car in cars)
            {
                // Check null fields
                if (car.Id == null) throw new ArgumentNullException("Id cannot be null");
                if (car.Name == null) throw new ArgumentNullException("Id cannot be null");
                if (car.Year == null) throw new ArgumentNullException("Id cannot be null");
                if (car.Brand == null) throw new ArgumentNullException("Id cannot be null");
                if (car.Type == null) throw new ArgumentNullException("Id cannot be null");
            }

            try
            {

                using (var writer = new StreamWriter(@"C:\Users\heyhe\development\cs-notes-and-code\challenges\CsvReader\Files\entity.csv", true))
                using (var csvWriter = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    Console.WriteLine("Inserting new cars on the list");
                    csvWriter.WriteRecords(cars);
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
                var result = _carList.FirstOrDefault(car => car.Id == id);

                using (var writer = new StreamWriter(@"C:\Users\heyhe\development\cs-notes-and-code\challenges\CsvReader\Files\entity.csv"))

                using (var csv = new CsvHelper.CsvReader(writer, CultureInfo.InvariantCulture))
                {
                    _carList = csv.GetRecords<Car>().ToList();

                    for(int i = 0; _carList.Count; ++i)
                    {
                        
                    }
                }

                    if (result != null)
                    {
                        _carList.RemoveAt(result.Id);
                        Console.WriteLine("Car removed from the list...");
                    }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IReadOnlyList<Car> List()
        {
            using (var reader = new StreamReader(@"C:\Users\heyhe\development\cs-notes-and-code\challenges\CsvReader\Files\entity.csv"))
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
