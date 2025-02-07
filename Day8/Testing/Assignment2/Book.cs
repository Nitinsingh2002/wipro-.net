using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Book
    {
                      
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }

        public bool IsBorrowed { get; set; }

        public Book (string  title, string author,string isbn)
        {
           Title = title;
            Author = author;
            ISBN = isbn;
        }


        public void  Boorow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
            }
        }


        public void ReturnBook()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
            }
        }
    }
}
