using System;
using System.Collections.Generic;

namespace ConsoleLibrary.Models
{
  public class Library
  {

    public string Name { get; private set; }
    //private by default if accessor not specified
    List<Book> Books = new List<Book>();

    public void ViewBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
        string availableText = (book.Available ? "Available" : "Not Available");
        System.Console.WriteLine($"{i + 1} - {book.Title} {availableText}");
      }
    }

    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    public Library(string name)
    {
      Name = name;
    }

    private Book GetBookFromUserChoice()
    {
      if (Int32.TryParse(Console.ReadLine(), out int n))
      {
        n = n - 1;
        if (n < 0 || n >= Books.Count)
        {
          return null;
        }
        return Books[n];
      }
      return null;
    }


    public void CheckoutMenu()
    {
      var checkingoutabook = true;
      while (checkingoutabook)
      {
        Console.Clear();
        ViewBooks();
        Console.WriteLine($"{Books.Count} - GO BACK");
        Book book = GetBookFromUserChoice();

        if (book == null)
        {
          checkingoutabook = false;
        }
        else
        {
          book.Available = false;
        }

      }
    }

    internal void ReturnMenu()
    {
      throw new NotImplementedException();
    }
  }
}