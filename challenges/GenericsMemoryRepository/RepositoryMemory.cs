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
            Console.WriteLine($"Entity added with Id: {entity.Id}");
        }

        public T? SearchById(int id)
        {
            var result = _list.FirstOrDefault(item => item.Id == id);
            return result;
        }

        public IReadOnlyList<T> List()
        {
            return _list;
        }

        public void RemoveById(int id)
        {
            var result = _list.FirstOrDefault(item => item.Id == id);

            if (result != null)
            {
                _list.RemoveAt(result.Id);

            }
            else
            {

                Console.WriteLine("Item ID not found.");
            }
        }
    }
}
