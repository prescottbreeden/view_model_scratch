namespace view_models.Models
{
  public class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public int ReleaseYear { get; set; }
    public Book(string title, string author, int releaseYear)
    {
      Title = title;
      Author = author;
      ReleaseYear = releaseYear;
    }
  }
}