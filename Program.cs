using System;
using System.Collections.Generic;


namespace BookRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book1 = new Book("The Name of the Rose");

            var booklist = new List<Book>
            {
                new Book("1491","Charles C. Mann","EN", 2007),
                new Book("Simple","Yotam Ottolenghi","EN",2019),
                new Book("Pet Sematary","Stephen King","EN",1990)
            };

            var repo = new BookRepo();

            //repo.AddBookList(booklist);
            var fetchedBooks = repo.FetchAllBooks();

        }
    }
}
