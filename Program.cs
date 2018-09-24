using System;
using ConsoleLibrary.Models;

namespace ConsoleLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      var library = new Library("LIBRARY!");
      var mobyDick = new Book("Moby Dick", "Herman Melville", "1", "1470");
      var lotr = new Book("The Fellowship", "Grey beard", "2196848-161", "1954");
      var hp = new Book("Harry Potter and the Chamber of Secrets", "JK Rowling", "215646897846549845195798496848-1251561161", "1998", false);
      library.AddBook(mobyDick);
      library.AddBook(lotr);
      library.AddBook(hp);

      Console.WriteLine(library.Name);
      library.ViewBooks();

      var inthelibrary = true;
      while (inthelibrary)
      {
        Console.Clear();
        Console.WriteLine("Welcome to " + library.Name);
        Console.WriteLine("things you can do here");
        Console.WriteLine("1 - Checkout book");
        Console.WriteLine("2 - Return book");
        Console.WriteLine("3 - Quit");
        Console.WriteLine("What would you like to do?");

        var userInput = Console.ReadLine();
        if (Int32.TryParse(userInput, out int choice))
        {
          switch (choice)
          {
            case 1:
              library.CheckoutMenu();
              break;
            case 2:
              library.ReturnMenu();
              break;
            case 3:
              inthelibrary = false;
              Console.Clear();
              Console.WriteLine("Bye Felicia");
              break;
            default:
              System.Console.WriteLine("Invalid Choice Try again");
              break;
          }

        }

      }



    }
  }
}
