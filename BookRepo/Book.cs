using System;
namespace BookRepo
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Language;
        public int YearPublished;
        public int Quantity;

        public Book(string title, string author, string lang, int year, int quant)
        {
            Title = title;
            Author = author;
            Language = lang;
            YearPublished = year;
            Quantity = quant;

        }

        override public string ToString()
        {
            return $"{Title},{Author},{Language},{YearPublished},{Quantity}";
        }
    }
}
