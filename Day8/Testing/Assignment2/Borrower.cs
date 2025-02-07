using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Borrower
    {
        public string? Name{get; set;}
        public int LibraryCardNumber { get; set;}

        public List<Book>? Books = new List<Book>();

        public Borrower(string name,int number)
        {
            Name = name;
            LibraryCardNumber = number;
        }


        public void BorrowBook(Book book)
        {
            if (!book.IsBorrowed)
            {
                book.Boorow();
                Console.WriteLine($"User {Name} borrowed {book.Title}");
            }
        }


        public void ReturnBook(Book book) {
            if (book.IsBorrowed)
            {
                book.ReturnBook();
                Console.WriteLine($"User {Name} returned book {book.Title}");
            }
        }


    }
}
