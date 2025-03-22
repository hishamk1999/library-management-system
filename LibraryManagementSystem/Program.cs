namespace LibraryManagementSystem
{

    class Book(string title, string author, string ISBn)
    {
        // Automatic Properties
        public string Title { get; private set; } = title;
        public string Author { get; private set; } = author;
        public string ISBN { get; private set; } = ISBn;
        public bool Availability { get; set; } = true;
    }

    class Library
    {
        public List<Book> LibraryList { get; private set; } = new List<Book>();


        public void AddBook(Book book)
        {
            LibraryList.Add(book);
        }

        public void BorrowBook(string bookName)
        {
            for (int i = 0; i < LibraryList.Count; i++)
            {
                if (LibraryList[i].Title == bookName)
                {
                    LibraryList[i].Availability = false;
                }

            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();
        }
    }
}
