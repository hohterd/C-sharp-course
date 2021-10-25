using System;
using CustomClassesLibrary;

namespace BookLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Whom Bell Tolls", 637, "Ernest Miller Hemingway");
            Book bookTwo = new Book("If it Bleeds", 496);

            Console.WriteLine(Library.AddBookToLibrary(bookOne));
            Console.WriteLine(Library.AddBookToLibrary(bookTwo));

            /*
            Console.WriteLine(Library.InformationAboutBookByIndex(0));
            Console.WriteLine(Library.InformationAboutBookByIndex(1));
            Console.WriteLine(Library.InformationAboutBookByIndex(-1));
            Console.WriteLine(Library.InformationAboutBookByIndex(3));
            */

            /*Console.WriteLine(Library.InformationAboutBookByName("whom bell tolls"));
            Console.WriteLine(Library.InformationAboutBookByName("WhOM bEll TolLS"));
            Console.WriteLine(Library.InformationAboutBookByName("If it Bleeds"));
            Console.WriteLine(Library.InformationAboutBookByName("Flower of Kamaleynyk"));
            Console.WriteLine(Library.InformationAboutBookByName("qweqweqwef"));*/

            /*Console.WriteLine(Library.DeleteBookFromLibraryByName("Flower of Kamaleynyk"));
            Console.WriteLine(Library.DeleteBookFromLibraryByIndex(7));
            Console.WriteLine(Library.DeleteBookFromLibraryByName("WhOM bEll TolLS"));
            Console.WriteLine(Library.DeleteBookFromLibraryByIndex(1));
            Console.WriteLine(Library.DeleteBookFromLibraryByName("WhOM bEll TolLS"));
            Console.WriteLine(Library.DeleteBookFromLibraryByIndex(1));*/

            Console.WriteLine(Library.FindTheBiggestOneBook(Library.Books));
        }
    }
}
