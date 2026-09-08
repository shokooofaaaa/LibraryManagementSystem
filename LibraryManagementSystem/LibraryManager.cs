using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryManager
    {
        Library library = new Library();

        public void AddBook(string Author, string Title)
        {
            Book book = new Book();
            LibraryItem<Book> libraryItem = new LibraryItem<Book>();
            book.Author = Author;
            libraryItem.Title = Title;
            libraryItem.Details = book;
            library.AddItem(libraryItem);


        }
        public void AddMagazine(int IssueNumber, string Title)
        {
            Magazine magazine = new Magazine();
            LibraryItem<Magazine> libraryMagazine = new LibraryItem<Magazine>();
            magazine.IssueNumber = IssueNumber;
            libraryMagazine.Title = Title;
            libraryMagazine.Details = magazine;
            library.AddItem(libraryMagazine);


        }

        public void AddDVD(int Duration, string Title)
        {
            DVD dvd = new DVD();
            LibraryItem<DVD> libraryDVDItem = new LibraryItem<DVD>();
            dvd.Duration = Duration;
            libraryDVDItem.Title = Title;
            libraryDVDItem.Details = dvd;
            library.AddItem(libraryDVDItem);


        }

        public List<Object> GetItems()
        {
            return library.GetItems();

        }

    }
}
