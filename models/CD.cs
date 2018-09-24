namespace ConsoleLibrary.Models
{
  public class CD
  //testing github repo - worx
  {
    public string Title { get; private set; }
    public string Artist { get; private set; }
    public string Published { get; private set; }
    public bool Available { get; set; }

    public CD(string title, string artist, string published, bool available = true)
    {
      Title = title;
      Artist = artist;
      Published = published;
      Available = available;
    }
  }
}