using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
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

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
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
