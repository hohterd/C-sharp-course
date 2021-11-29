using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary
{
    public class Book
    {
        public string BookName { get; set; }
        public string LibraryName { get; set; }
        public int NumberOfPages { get; set; }
        public string Author { get; set; }

        public Book()
        {

        }

        public Book(string name, int numberOfPages)
        {
            BookName = name;
            NumberOfPages = numberOfPages;
        }

        public Book(string name, int numberOfPages, string author)
        {
            BookName = name;
            NumberOfPages = numberOfPages;
            Author = author;
        }

    }
}
