using System;

namespace BookTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("-----------1234567890123---ddwaka$$%---------------------");
            var catalog = new Catalog();

            catalog.SetBook("1234567890123", book);
            catalog.GetBook("123456789wdladlad0123");       

        }
    }
}
