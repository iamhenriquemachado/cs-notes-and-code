using cs_notes_and_code.challenges.CsvReader.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CsvReader.Entities
{
    internal class Car 
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
    }
}
