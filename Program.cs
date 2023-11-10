using LibraryApp.Models;

LibraryManager lib1 = new LibraryManager();
Author author = new Author("Ferdinand-Oyono", "Literature");
Book newBook = new Book("Une vie de Boy", "Roman", author, "978-0-7564-0927-6");

lib1.AddBook(newBook);
//System.Console.WriteLine(lib1);
Console.WriteLine("Added book title: " + newBook.Title);

Console.WriteLine("Books in library:");
foreach (Book book in lib1.ListBooks())
{
    Console.WriteLine("- " + book.Title);
}
Novel novel = new Novel("Drama");
System.Console.WriteLine(novel);

Romance amour = new Romance("Romeo et Juliette");
System.Console.WriteLine(amour);

Magazine magazine = new Magazine("2002");
System.Console.WriteLine(magazine);

