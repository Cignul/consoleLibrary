namespace ConsoleLibrary.Models
{
  public class Book
  {
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
    public string Published { get; private set; }
    public bool Available { get; set; }

    public Book(string title, string author, string isbn, string published, bool available = true)
    {
      Title = title;
      Author = author;
      ISBN = isbn;
      Published = published;
      Available = available;
    }
  }
}