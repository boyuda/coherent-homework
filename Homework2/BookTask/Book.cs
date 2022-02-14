using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTask
{
    class Book
    {
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public List<string> BookAuthors { get; set; }
        public string ISBN { get; private set; }

        public Book(string isbn)
        {
            if (isbn.Contains('-'))
            {
               isbn = isbn.Replace("-", "");
            }
            else if(isbn.Length == 13 && isbn.All(char.IsDigit))
            {
                ISBN = isbn;
                Title = "";
                BookAuthors = new List<string>();
                PublicationDate = null;
            } 
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }

    }
}
