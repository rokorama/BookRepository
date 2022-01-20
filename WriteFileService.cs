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

        public void WriteAllText(string[] lines)
        {
            File.AppendAllLines(_dbLocation, lines);
        }

        public List<string> GetAllLines()
        {
            var allLines = File.ReadAllLines(_dbLocation);
            return allLines.ToList();
        }

    }
}