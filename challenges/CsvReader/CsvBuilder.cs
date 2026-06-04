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
