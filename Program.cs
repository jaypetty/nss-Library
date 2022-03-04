using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager myCollection = new LibraryManager("Jasmine's");

            Console.WriteLine($"Welcome to {myCollection.Name} Library Management System!");

            //Instance of the Book class in Book.cs
            Book hobbits = new Book
            {
                Title = "The Hobbit",
                Author = "J. R. R. Tolkien",
                PublishDate = new DateTime(1937, 9, 21),
                Genre = "High fantasy Juvenile fantasy"
            };
            Book giver = new Book
            {
                Title = "The Giver",
                Author = "Lois Lowry",
                PublishDate = new DateTime(2014, 9, 15),
                Genre = "Science fiction"
            };
            Book harryPotter = new Book
            {
                Title = "Harry Potter & The Goblet Of Fire",
                Author = "J. K. Rowling",
                PublishDate = new DateTime(2000, 7, 8),
                Genre = "Fantasy Fiction"
            };

            myCollection.AddABook(hobbits);
            myCollection.AddABook(giver);
            myCollection.AddABook(harryPotter);

            myCollection.DisplayBooks();

            //books I created above stored in a list.    
            List<Book> myBookList = new List<Book> {giver, hobbits, harryPotter};

            
        }
    }
}
