using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.BookLibrary
{
    internal class BookLibrary
    {
        private List<Book> _book = new List<Book>();
        private Dictionary<string, Book> _bookList = new Dictionary<string, Book>();
        private HashSet<string> _registeredIsbn = new HashSet<string>();

        public void AddBook(string title, string author, string? isbn)
        {

            if (isbn != null)
            {
                if (_registeredIsbn.Contains(isbn))
                {
                    Console.WriteLine($"ISBN already registered in the list: {isbn}");
                    return;
                }

                Book book = new Book()
                {
                    Title = title,
                    Author = author,
                    Isbn = isbn ?? "No ISBN provided"
                };


                _bookList.Add(title, book);
                _registeredIsbn.Add(isbn);
                Console.WriteLine($"Book added to the list: {book.Title}");
            }


        }

        public void SearchByTitle(string title)
        {

            bool found = false;

            if (_bookList.TryGetValue(title, out var bookTitle))
            {
                found = true;
                Console.WriteLine($"Book found {bookTitle.Title}");
            }

            if (!found)
            {
                Console.WriteLine("Book not found");
            }

        }

        public void RemoveByTitle(string title)
        {

            bool found = false;
            if (_bookList.TryGetValue(title, out var t))
            {
                var isbn = t.Isbn;

                if (isbn != "No ISBN provided")
                {
                    _registeredIsbn.Remove(isbn);
                }

                _bookList.Remove(title);
                found = true;
                Console.WriteLine("Book removed from the list...");
            }

            if (!found)
            {
                Console.WriteLine("Book not found in the list to be removed...");
            }
        }
    
        public void ListAll()
        {
            foreach (var item in _bookList.Values)
            {
                Console.WriteLine($"{item.Title} - {item.Author}");
            }
        }
    }



}