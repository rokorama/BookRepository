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
            bool BookToUpdate = false;
            var bookList = FetchAllBooks();
            foreach (Book entry in bookList)
            {
                if (book.Title == entry.Title && book.Author == entry.Author)
                {
                    entry.Quantity++; // still doesn't save new quantity to file
                    Console.WriteLine($"Book already exists, adding 1 to current tall, new total - {entry.Quantity}");
                    BookToUpdate = true;
                }
            }
            if (BookToUpdate == true)
                writeFileService.OverwriteText(bookList);
            else
                writeFileService.AppendText(book.ToString());
        }

        public void SaveBookList(List<Book> inputList)
        {
            var inputArray = new string[inputList.Count];
            int index = 0;
            foreach (Book entry in inputList)
            {
                inputArray[index] = entry.ToString();
                index++;
            }
            writeFileService.AppendAllText(inputArray);
        }

        public List<Book> FetchAllBooks()
        {
            var resultList = new List<Book>();
            var fetchedList = writeFileService.GetAllLines();
            foreach (string entry in fetchedList)
            {
                var splitValues = entry.Split(",");
                var rebuiltBook = new Book(
                    splitValues[0],  // title
                    splitValues[1], // author
                    splitValues[2], // language
                    Convert.ToInt32(splitValues[3]), // year published
                    Convert.ToInt32(splitValues[4])); // quantity
                resultList.Add(rebuiltBook);
            }
            return resultList;
        }

        private void SaveChanges(List<Book> inputList)
        {
            this.FetchAllBooks();
            
        }

// 1. Check if such a book already exists, if so add a counter to an existing one
// (For example a book is saved like this "Twilight 7"
// 2. Create a Reader entity which is capable of "borrowing" a book which means getting it
// from file(therefore removing 1 from counter) and putting it into a private list.
// 3. Create a method in a Reader class to give a book back therefore adding +1 in a file
// and removing from its private list.


    }
}
