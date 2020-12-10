using System.ComponentModel.DataAnnotations;

namespace csharplibrary.Models
{
  public class Book
  {
    [Required]
    [Range(0, 2000, ErrorMessage = "That book is too long to be in this collection!")]

    public int Pages { get; set; }

    public string Author { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }


    public Book(string author, string title, string summary, int pages)
    {
      Pages = pages;
      Author = author;
      Title = title;
      Summary = summary;
    }

  }
}