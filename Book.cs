using System;
namespace BookRepo
{
    public class Book
    {
        public string Title;
        public string Author;

        //public string Genre;
        public string Language;
        public int YearPublished;
        //public int Pages;
        //public Guid ID;

        public Book(string title, string author, string lang, int year)
        {
            Title = title;
            Author = author;
            Language = lang;
            YearPublished = year;

        }

        //public Book(string title, string author, string genre, string language,
        //    int yearPublished, int pages, Guid id)
        //{
        //    Title = title;
        //    Author = author;
        //    Genre = genre;
        //    Language = language;
        //    YearPublished = yearPublished;
        //    Pages = pages;
        //    ID = id;
        //}

    }
}
