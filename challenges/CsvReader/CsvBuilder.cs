using cs_notes_and_code.challenges.GenericsMemoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CsvReader
{
    internal class CsvBuilder<T> : IRepository<T> where T : class, IEntity
    {
        List<T> _list = new List<T>();

        public bool CreateCsvFile()
        {
            string filePath = @"C:\Users\heyhe\development\cs-notes-and-code\challenges\CsvReader\Files\Entity.csv";

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                Console.WriteLine($"Path and File Created at: {filePath}");

                return true;
            }
            else
            {
                return false;
            }

        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<T> List()
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public T? SearchById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
