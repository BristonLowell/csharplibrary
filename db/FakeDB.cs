using System.Collections.Generic;
using csharplibrary.Models;

namespace csharplibrary.db
{
  public class FakeDB
  {
    public static List<Book> books { get; set; } = new List<Book>(){
        new Book("J.R.R Tolkein", "LOTR-ROTK", "Short Hobbit takes the ring to lava and hesitates to throw it in", 347),
        new Book("J.R.R Tolkein", "LOTR-FOTR", "Short Hobbit gets asked to go on dangerous adventure", 479),
        new Book("J.R.R Tolkein", "LOTR-TTT", "Short Hobbit does nothing while battles break out", 415),
      };
  }
}