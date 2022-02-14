using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTask
{
    class Catalog
    {
        private Dictionary<string, Book> BookCatalog { get; set; }

        public Catalog()
        {
            BookCatalog = new Dictionary<string, Book>();
        }

        //Get and Set book methods.
        public Book GetBook(string key)
        {
            if (key.Contains('-'))
            {
                key = key.Replace("-", "");
            }

            if (!(BookCatalog.ContainsKey(key)))
            {
                throw new ArgumentException("Wrong key");
            }

            return BookCatalog[key];
        }

        public void SetBook(string key, Book value)
        {
            if (BookCatalog.ContainsKey(key))
            {
                BookCatalog[key] = value;
            }
            else
            {
                BookCatalog.Add(key, value);
            }
        }
    }
}
