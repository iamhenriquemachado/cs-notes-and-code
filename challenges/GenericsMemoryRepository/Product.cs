using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.GenericsMemoryRepository
{
    internal class Product : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
