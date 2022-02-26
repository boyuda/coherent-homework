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

        public Book(string title, DateTime publicationDate, string isbn, List<string> bookAuthors)
        {
            isbn = String.Join("", isbn.Where(char.IsDigit));

            if(string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty");
            }


            if(bookAuthors.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                throw new ArgumentException("Author repeating");
            }


            if (isbn.Length == 13)
            {
                ISBN = isbn;
                Title = title;
                BookAuthors = bookAuthors;
                PublicationDate = publicationDate;
            } 
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }

    }
}
