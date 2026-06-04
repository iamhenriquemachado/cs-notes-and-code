using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CsvReader.Interfaces
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        void DeleteById(int id);
        IReadOnlyList<T> List();
        T? SearchById(int id);
    }
}
