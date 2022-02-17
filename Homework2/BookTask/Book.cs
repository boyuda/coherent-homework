using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTask
{
    class Book
    {
        public string Title { get; private set; }
        public DateTime? PublicationDate { get; private set; }
        public List<string> BookAuthors { get; private set; }
        public string ISBN { get; private set; }

        public Book(string isbn)
        {
            isbn = String.Join("", isbn.Where(char.IsDigit));

            if(isbn.Length == 13)
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
