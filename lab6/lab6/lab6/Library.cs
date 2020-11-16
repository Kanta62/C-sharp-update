using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        private Book[] listOfBook;

        public Book[] ListOfBook
        {
            get { return listOfBook; }
            set { listOfBook = value; }
        }



        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }


        private int bookCount;
        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
        }

        private Account[] lAccount;

        public Account[] LAccount
        {
            get { return lAccount; }
            set { lAccount = value; }
        }

        public Library()
        {
            listOfBook = new Book[50000];
            lAccount = new Account[1];
        }

        public Library(string libName, string libAddress, int totalBook)
        {
            listOfBook = new Book[50000];
            lAccount = new Account[1];
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
        }


        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Total books: " + totalBook);
            Console.WriteLine(bookCount);
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("Book ount: " + bookCount);
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Book " + (i + 1) + " in library:");
                Console.WriteLine("Book Name: " + listOfBook[i].BookName);
                Console.WriteLine("Book Author: " + listOfBook[i].BookAuthor);
                Console.WriteLine("Book Id: " + listOfBook[i].BookId);
                Console.WriteLine("Book Type: " + listOfBook[i].BookType);
                Console.WriteLine("Book Copy: " + listOfBook[i].BookCopy);
                Console.WriteLine(" ");
            }
        }

        public void AddNewBook(Book book)
        {
            listOfBook[bookCount++] = book;
        }

        public void DeleteBook(Book book)
        {
            listOfBook[bookCount--] = book;
        }

        public void AddNewBookCopy(Book book, int copy)

        {
            Console.WriteLine(copy + " books added to " + book.BookName);
            book.AddBookCopy(copy);
        }
    }
}
