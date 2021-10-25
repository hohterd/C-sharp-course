using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary
{
    public static class Library
    {
        private static string LibraryName { get; set; }
        public static Book[] Books { get; set; }

        static Library()
        {
            LibraryName = "The Minsk Public Library";
            Books = new Book[100];
        }


        public static string InformationAboutBookByIndex(int index)
        {
            if(index >= 0 && index < Books.Length)
            {
                if (Books[index] != null)
                {
                    if (Books[index].Author != null)
                    {
                        return
                            $"Book title: {Books[index].BookName}, book author: {Books[index].Author}, number of pages:{Books[index].NumberOfPages}, the book is in the library: {Books[index].LibraryName}";
                    }
                    else
                        return $"Book title: {Books[index].BookName}, number of pages:{Books[index].NumberOfPages}, the book is in the library: {Books[index].LibraryName}";
                }
            }
            return $"Book with index: {index} doesn't exist";
        }

        public static string InformationAboutBookByName(string bookName)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null && string.Equals(Books[i].BookName, bookName, StringComparison.OrdinalIgnoreCase))
                {
                    if (Books[i].Author != null)
                    {
                        return
                            $"Book title: {Books[i].BookName}, book author: {Books[i].Author}, number of pages:{Books[i].NumberOfPages}, the book is in the library: {Books[i].LibraryName}";
                    }
                    else 
                        return $"Book title: {Books[i].BookName}, number of pages:{Books[i].NumberOfPages}, the book is in the library: {Books[i].LibraryName}";
                }
            }
            return $"Book with name: {bookName} doesn't exist";
        }

        public static string AddBookToLibrary(Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] == null)
                {
                    book.LibraryName = LibraryName;
                    Books[i] = book;
                    return $"Book: {book.BookName} added to library: {LibraryName}";
                }
                else continue;
            }
            return $"{LibraryName} is full, book {book.BookName} not added";
        }

        public static string DeleteBookFromLibraryByName(string bookName)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if(Books[i] != null && string.Equals(Books[i].BookName, bookName, StringComparison.OrdinalIgnoreCase))
                {
                    Books[i] = null;
                    return $"Book {bookName} deleted from library {LibraryName}";
                }
                else continue;
            }
            return $"Book with name: {bookName} doesn't exist";
        }

        public static string DeleteBookFromLibraryByIndex(int index)
        {
            if(index >= 0 && index < Books.Length)
            {
                if (Books[index] != null)
                {
                    Books[index] = null;
                    return $"Book with index {index} deleted from library {LibraryName}";
                }
            }
            return $"Book with index: {index} doesn't exist";
        }

        public static string FindTheBiggestOneBook(this Book[] books)
        {
            Book book = books[0];
            for (int i = 1; i < books.Length; i++)
            {
                if (books[i] != null && books[i].NumberOfPages > book.NumberOfPages)
                {
                    book = books[i];
                }
                else continue;
            }
            return $"Book with name {book.BookName} biggest ones in {LibraryName}";
        }


    }
}
