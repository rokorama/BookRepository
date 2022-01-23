using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookRepo
{
    public class WriteFileService
    {
        private readonly string _dbLocation = @"/Users/crisc/csharp/BookRepo/BookRepo/db.txt";


        public void AppendText(string input)
        {
            using (StreamWriter sw = File.AppendText(_dbLocation))
            {
                sw.WriteLine(input);
            }
        }
        public void OverwriteText(List<Book> bookList)
        {
            var conversionList = new List<string>();
            foreach (Book entry in bookList)
            {
                conversionList.Add(entry.ToString());
            }
            using(TextWriter tw = new StreamWriter(_dbLocation))
            {
                foreach (string entry in conversionList)
                tw.WriteLine(entry);
            }
            // bookList.
            // var conversionArray = conversionList.ToArray();
            // File.WriteAllText(_dbLocation, conversionArray);
        }

        public void AppendAllText(string[] lines)
        {
            File.AppendAllLines(_dbLocation, lines);
        }
        public void OverwriteText(string[] lines)
        {
            File.WriteAllLines(_dbLocation, lines);
        }

        public List<string> GetAllLines()
        {
            var allLines = File.ReadAllLines(_dbLocation);
            return allLines.ToList();
        }

    }
}