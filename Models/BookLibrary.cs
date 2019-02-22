using System.Collections.Generic;

namespace view_models.Models
{
  public class BookLibrary
  {
    public List<Book> AllBooks { get; set; } = new List<Book>();
    private int BookCount { get; set; }
    public BookLibrary()
    {
      AllBooks.Add(new Book(1, "Hamlet", "Bill Shakespeare", 1602));
      AllBooks.Add(new Book(2, "Moby Dick", "Hermit Melville", 1851));
      AllBooks.Add(new Book(3, "Frankenstein", "Merry Shelly", 1818));
      AllBooks.Add(new Book(4, "Lord of the Rings", "J.R.R. Token", 1954));
      AllBooks.Add(new Book(5, "Harry Potter", "J.K. Bowling", 1998));
    }
  }
}