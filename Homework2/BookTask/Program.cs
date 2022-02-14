using System;

namespace BookTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("12-34-5678-9123-1");
            var catalog = new Catalog();

            catalog.SetBook(book.ISBN, book);
            catalog.GetBook("123456789123-1");       

        }
    }
}
