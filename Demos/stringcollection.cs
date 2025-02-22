using System;
using System.Collections.Specialized;

public class FavoriteBooks
{
    private StringCollection books = new StringCollection();

    public void AddBook(string book)
    {
        books.Add(book);
    }

    public void RemoveBook(string book)
    {
        books.Remove(book);
    }

    public void DisplayBooks()
    {
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
    }
}

public class Program
{
    public static void Main()
    {
        FavoriteBooks favoriteBooks = new FavoriteBooks();
        favoriteBooks.AddBook("To Kill a Mockingbird");
        favoriteBooks.AddBook("1984");
        favoriteBooks.AddBook("The Great Gatsby");

        Console.WriteLine("Favorite Books:");
        favoriteBooks.DisplayBooks();

        favoriteBooks.RemoveBook("1984");

        Console.WriteLine("After removal:");
        favoriteBooks.DisplayBooks();
    }
}
