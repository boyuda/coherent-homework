using System;
using System.Collections.Generic;

namespace BookTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> authors = new List<string>();
            authors.Add("S. King");
            authors.Add("A. Lindgren");

            var book = new Book("C# Programming", new DateTime(2022, 01, 15), "-----------1234567890123---ddwaka$$%---------------------", authors);

            authors.Add("S. King");
            authors.Add("A. Lindgren");
            var catalog = new Catalog();

            catalog.SetBook("1234567890123", book);
            catalog.GetBook("123456789wdladlad0123");       

        }
    }
}
