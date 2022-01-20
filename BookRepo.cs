using System;
using System.Collections.Generic;
using System.IO;

namespace BookRepo
{
    public class BookRepo
    {
        public List<Book> BookList;
        public WriteFileService writeFileService;

        public BookRepo()
        {
            writeFileService = new WriteFileService();
        }

        public void SaveBook(Book book)
        {
            writeFileService.AppendText(book.Title);
        }

        public void AddBookList(List<Book> inputList)
        {
            var inputArray = new string[inputList.Count];
            int index = 0;
            foreach (Book entry in inputList)
            {
                inputArray[index] = $"{entry.Title},{entry.Author},{entry.Language},{entry.YearPublished}";
                index++;
            }
            writeFileService.WriteAllText(inputArray);
        }

        public List<Book> FetchAllBooks()
        {
            var resultList = new List<Book>();
            var fetchedList = writeFileService.GetAllLines();
            foreach (string entry in fetchedList)
            {
                var splitValues = entry.Split(",");
                var rebuiltBook = new Book(splitValues[0], splitValues[1],
                    splitValues[2], Convert.ToInt32(splitValues[3]));
                resultList.Add(rebuiltBook);
            }
            return resultList;
        }


    }
}
