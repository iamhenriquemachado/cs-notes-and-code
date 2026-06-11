using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Interfaces
{
    internal interface IProductRepository
    {
        void Add(Product product);
        Product? GetById(int id);
        IReadOnlyList<Product> List();
        void Remove(int id);
    }
}
