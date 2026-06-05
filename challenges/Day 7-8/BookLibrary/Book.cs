using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.BookLibrary
{
    internal class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public string? Isbn { get; set; }

    }
}
