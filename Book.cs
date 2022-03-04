using System;

namespace Library
{
    //create a class called Book . Put it in the same namespace as the Program class.
    class Book
    {
        //The Book class should have Title, Author, PublishDate, and Genre properties.
        public string Title {get; set;}
        public string Author {get; set;}
        public DateTime PublishDate {get; set;}
        public string Genre {get; set;}
    }
}