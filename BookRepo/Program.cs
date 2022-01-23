using System;
using System.Collections.Generic;


namespace BookRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO menu view with main menu, viewing all books, adding or deleting a book &
            // maybe sorting by key 

            var entry = new Book("1491","Charles C. Mann","EN",2007,1);
            var bookRepo = new BookRepo();
           bookRepo.SaveBook(entry);
        }
    }
}
