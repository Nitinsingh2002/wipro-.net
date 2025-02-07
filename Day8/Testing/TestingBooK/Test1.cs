using Assignment2;

namespace TestingBooK
{


    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAddingBookToLibrary()
        {
            //arrange
            Library lb = new Library();
            Book b = new Book("C#", "Nitin kumar singh", "12345");

            //act
            lb.AddBook(b);
            //Assert
            Assert.AreEqual(1, lb.books.Count);
            Assert.AreEqual("C#", lb.books[0].Title);
            Assert.AreEqual("Nitin kumar singh", lb.books[0].Author);
            Assert.AreEqual("12345", lb.books[0].ISBN);

        }

        [TestMethod]
        public void RegisteringBorrower()
        {
            //Arrange
            Library lb = new Library();
            Borrower b = new Borrower("Nitin kumar singh", 1234);

            //Act
            lb.ResgisterBorrower(b);

            Assert.AreEqual(1, lb.borrowers.Count);
            Assert.AreEqual("Nitin kumar singh", lb.borrowers[0].Name);
            Assert.AreEqual(1234, lb.borrowers[0].LibraryCardNumber);
        }


        [TestMethod]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            // Arrange
            Library library = new Library();
            Book book = new Book("C# Programming", "Nitin", "12345");
            library.AddBook(book);
            Borrower borrower = new Borrower("Rakesh", 1001);
            library.ResgisterBorrower(borrower);

            // Act
            library.BorrowBook("12345", 1001);

            // Assert
            Assert.IsTrue(book.IsBorrowed);
        }

        [TestMethod]
        public void BorrowBook_ShouldAssociateBookWithBorrower()
        {
            // Arrange
            Library library = new Library();
            Book book = new Book("C# Programming", "Nitin", "12345");
            library.AddBook(book);
            Borrower borrower = new Borrower("Rakesh", 1001);
            library.ResgisterBorrower(borrower);

            // Act
            library.BorrowBook("12345", 1001);

            // Assert
            Assert.AreEqual(1, borrower.Books.Count);
            Assert.AreEqual("C# Programming", borrower.Books[0].Title);
        }



        [TestMethod]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            // Arrange
            Library library = new Library();
            Book book = new Book("C# Programming", "John Doe", "12345");
            library.AddBook(book);
            Borrower borrower = new Borrower("Alice Johnson", 1001);
            library.ResgisterBorrower(borrower);
            library.BorrowBook("12345", 1001);

            // Act
            library.ReturnBook("12345", 1001);

            // Assert
            Assert.IsFalse(book.IsBorrowed);
        }

        [TestMethod]
        public void ReturnBook_ShouldRemoveBookFromBorrowersList()
        {
            // Arrange
            Library library = new Library();
            library = new Library();
            library.books = new List<Book>();
            library.borrowers = new List<Borrower>();


            Book book = new Book("C# Programming", "John Doe", "12345");
            library.AddBook(book);
            Borrower borrower = new Borrower("Alice Johnson", 1001);
            library.ResgisterBorrower(borrower);
            library.BorrowBook("12345", 1001);

            // Act
            library.ReturnBook("12345", 1001);

            // Assert
            Assert.AreEqual(0, borrower.Books.Count);
        }



        [TestMethod]
        public void ViewBooks_ShouldDisplayCorrectBookInformation()
        {

            // Arrange
            Library library = new Library();
            library.books = new List<Book>();
            library.borrowers = new List<Borrower>();

            Book book1 = new Book("C# Programming", "Nitin", "12345");
            Book book2 = new Book("Java Programming", "Rakesh", "67890");
            library.AddBook(book1);
            library.AddBook(book2);

            // Act
            StringWriter sw = new StringWriter(); // To capture Console.WriteLine output
            Console.SetOut(sw);
            library.viewBooks();

            // Assert
            string output = sw.ToString();
            Assert.IsTrue(output.Contains("C# Programming"));
            Assert.IsTrue(output.Contains("Nitin"));
            Assert.IsTrue(output.Contains("12345"));
            Assert.IsTrue(output.Contains("Available"));

            Assert.IsTrue(output.Contains("Java Programming"));
            Assert.IsTrue(output.Contains("Rakesh"));
            Assert.IsTrue(output.Contains("67890"));
            Assert.IsTrue(output.Contains("Available"));
        }

        [TestMethod]
        public void ViewBorrowers_ShouldDisplayCorrectBorrowerInformation()
        {
            // Arrange
            Library library = new Library();
            Book book = new Book("C# Programming", "Nitin", "12345");
            library.AddBook(book);
            Borrower borrower = new Borrower("Rakesh", 1001);
            library.ResgisterBorrower(borrower);
            library.BorrowBook("12345", 1001);

            // Act
            StringWriter sw = new StringWriter(); // To capture Console.WriteLine output
            Console.SetOut(sw);
            library.ViewBorrowers();

            // Assert
            string output = sw.ToString();
            Assert.IsTrue(output.Contains("Rakesh"));
            Assert.IsTrue(output.Contains("1001"));
            Assert.IsTrue(output.Contains("1")); // Because 1 book is borrowed
            Assert.IsTrue(output.Contains("C# Programming"));
        }

    }
}
