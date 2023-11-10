namespace LibraryApp.Models;

public class LibraryManager
{
    //private List<Book> books;
    //private List<Borrower> borrowers;
    //private List<Author> authors;

    private List<Book> books = new List<Book>();
    private List<Borrower> borrowers = new List<Borrower>();
    private List<Author> authors = new List<Author>();

    public void AddBook(Book book)
    {
        books.Add(book);
        // Book.Add(books);
    }
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }
    public void AddBorrower(Borrower borrower)
    {
        borrowers.Add(borrower);
    }
    public void RemoveBorrower(Borrower borrower)
    {
        borrowers.Remove(borrower);
    }
    public void AddAuthor(Author author)
    {
        authors.Add(author);
    }
    public void RemoveAuthor(Author author)
    {
        authors.Remove(author);
    }

    public void CheckOutBook(Book book, Borrower borrower)
    {
        book.CheckOut();
        // borrower.CheckOut();
    }

    public void ReturnBook(Book book, Borrower borrower)
    {
        book.Return();
       //borrower.Return();
    }

    public List<Book> ListBooks()
    {
        return books;
    }
    public List<Borrower> ListBorrowers()
    {
        return borrowers;
    }
    public List<Author> ListAuthors()
    {
        return authors;
    }


    /*public LibraryManager()
    {
        books = new List<Book>();
        borrowers = new List<Borrower>();
        authors = new List<Author>();
    }*/

}

// creation de la class Book 
public class Book 
{
    public string Title { get; set; }
    public string Type { get; set; }
    public Author Author{ get; set; }
    public string ISBN { get ; set; }
    public bool CheckedOut { get; set; }

    public Book(string title, string type, Author author, string iSBN)
    {
        Title = title;
        Type = type;
        Author = author;
        ISBN = iSBN;
        //this.Title = title; 
        //this.Type = type;
        //this.Author = author;
        //this.ISBN = iSBN;

    }

    public string GetTitle()
    {
        return Title;
    }
    public Author GetAuthor()
    {
        return Author;
    }

    public string GetISBN()
    {
        return ISBN;
    }
    public bool IsCheckedOut()
    {
        return CheckedOut;
    }
    public void CheckOut()
    {
        CheckedOut = true;
    }
    public void Return()
    {
        CheckedOut = false;
    }

}

public class Borrower
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public Borrower(string name, string address, string phone)
    {
        this.Name = name;
        this.Address = address;
        this.Phone = phone;
    }

}

public class Author
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public string GetName()
    {
        return Name;
    }
    public string GetBio()
    {
        return Bio;
    }

    public Author(string name, string bio)
    {
        this.Name = name;
        this.Bio = bio;
    }

}
    // public List<Book> books { get; } = new List<Book>();
