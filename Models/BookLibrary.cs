using System.Collections.Generic;

namespace view_models.Models
{
  public class BookLibrary
  {
    public List<Book> AllBooks { get; set; } = new List<Book>();
    public BookLibrary()
    {
      AllBooks.Add(new Book("Hamlet", "Bill Shakespeare", 1602));
      AllBooks.Add(new Book("Moby Dick", "Hermit Melville", 1851));
      AllBooks.Add(new Book("Frankenstein", "Merry Shelly", 1818));
      AllBooks.Add(new Book("Lord of the Rings", "J.R.R. Token", 1954));
      AllBooks.Add(new Book("Harry Potter", "J.K. Bowling", 1998));
    }
  }
}