using csharplibrary.Models;
using csharplibrary.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace csharplibrary.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class BookController : ControllerBase
  {
    private readonly BookService _bs;

    public BookController(BookService bs)
    {
      _bs = bs;
    }


    [HttpGet]

    public ActionResult<IEnumerable<Book>> GetAll()
    {
      try
      {
        return Ok(_bs.GetALL());
      }
      catch (System.Exception err)
      {

        return BadRequest(err);
      }
    }

    [HttpPost]

    public ActionResult<Book> Create([FromBody] Book newBook)
    {
      try
      {
        return Ok(_bs.Create(newBook));
      }
      catch (System.Exception err)
      {

        return BadRequest(err);
      }
    }

    [HttpDelete("{index}")]

    public ActionResult<string> Delete(int index)
    {
      try
      {
        return Ok(_bs.Delete(index));
      }
      catch (System.Exception err)
      {

        return BadRequest(err);
      }
    }

    [HttpPut("{index}")]

    public ActionResult<Book> Edit(int index, [FromBody] Book editedBook)
    {
      try
      {
        return Ok(_bs.Edit(index, editedBook));
      }
      catch (System.Exception err)
      {

        return BadRequest(err);
      }
    }


  }
}