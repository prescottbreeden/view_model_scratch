using view_models.Models;

namespace view_models
{
  public class Dashboard
  {
    public User CurrentUser { get; set; }
    public BookLibrary Books { get; set; }
    public Dashboard(User currentUser, BookLibrary books)
    {
      CurrentUser = currentUser;
      Books = books;
    }
  }
}