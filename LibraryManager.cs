using System;
using System.Collections.Generic;

namespace Library
{
    class LibraryManager
    {
        private List<Book> _books = new List<Book> { };
        public string Name { get; set; }
        public LibraryManager(string library)
        {
            Name = library;
        }
        public void AddABook(Book givenBook)
        {
            _books.Add(givenBook);
        }
        public void DisplayBooks()
        {
            foreach (Book eachBook in _books)
            {
                Console.WriteLine($"{eachBook.Title}, by {eachBook.Author}");
            }
        }
    }
}