using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.GenericsMemoryRepository
{
    internal interface IRepository<T> 
    {
        void Add(T entity);
        void SearchById(int id);
        IReadOnlyList<T> List();
        void RemoveById(int id);
    }
}
