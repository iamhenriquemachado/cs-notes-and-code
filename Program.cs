using cs_notes_and_code.challenges.BookLibrary;
using cs_notes_and_code.challenges.ContactBook;


Book book = new Book() { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Isbn = "" };

BookLibrary bookLibrary = new BookLibrary();

bookLibrary.AddBook(book.Title, book.Author, book.Isbn);
bookLibrary.SearchByTitle("The Great Gatsby");
