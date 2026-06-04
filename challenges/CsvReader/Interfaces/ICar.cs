using cs_notes_and_code.challenges.CsvReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CsvReader.Interfaces
{
    internal interface ICar
    {
        void Add(Car car);
        void DeleteById(int id);
        IReadOnlyList<Car> List();
        void SearchById(int id);
    }
}
