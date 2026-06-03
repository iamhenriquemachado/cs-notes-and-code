using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.GenericsMemoryRepository
{
    internal class RepositoryMemory<T> : IRepository<T> where T : class, IEntity
    {
        private readonly List<T> _list = new List<T>();

        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public void SearchById(int id)
        {
            var result = _list.Where(l => l.Id == id).FirstOrDefault();
            Console.WriteLine($"Result {result}");
        }

        public IReadOnlyList<T> List()
        {
            return _list;
        }

        public void RemoveById(int id)
        {
            _list.RemoveAt(id);
        }
    }
}
