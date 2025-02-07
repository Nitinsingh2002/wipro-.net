using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
     public class Library
    {
        public List<Book>? books;
        public List<Borrower>? borrowers;

        public Library()
        {
            books = new List<Book>();  
            borrowers = new List<Borrower>();  
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Title} added to the library");
        }


        public void  ResgisterBorrower(Borrower b)
        {
            //creating object of borrowes
            Borrower bo = new Borrower(b.Name, b.LibraryCardNumber);
            borrowers.Add(b);

            Console.WriteLine($"Borrower {b.Name} Registerd");
        }


        public void BorrowBook(string isbn, int libraryCardNumber)
        {
           //finding book by isbn
           Book book = books.Find(b =>b.ISBN ==  isbn);

            //finding borrowers
            Borrower br = borrowers.Find(b => b.LibraryCardNumber == libraryCardNumber);
            br.Books.Add(book);


            if (book.IsBorrowed)
            {
                Console.WriteLine("Book already borrowed");
            }

            br.BorrowBook(book);
        }


       public void ReturnBook(string isbn, int libraryCardNumber)
        {
            //finding book by isbn
            Book book = books.FirstOrDefault(b => b.ISBN == isbn);
            //finding borrowers
            Borrower borrower = borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

                
            if (book.IsBorrowed)
            {
                borrower.ReturnBook(book);
                borrower.Books.Remove(book);
            }
        }

        public void viewBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - ISBN: {book.ISBN} - {(book.IsBorrowed ? "Borrowed" : "Available")}");
            }
        }

        public void  ViewBorrowers()
        {
            foreach(Borrower borrower in borrowers)
            {
                Console.WriteLine($"{borrower.Name} (Card: {borrower.LibraryCardNumber}");

                Console.WriteLine("  Borrowed Books:");

                if (borrower.Books.Count > 0)
                {
                    foreach(Book book in borrower.Books)
                    {
                        Console.WriteLine(book.Title);
                    }
                }
                else
                {
                    Console.WriteLine("No books borrowed");
                }
            }
        }
        
    }
}

