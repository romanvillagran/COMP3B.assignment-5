using COMP3B.assignment_5.Data;
using COMP3B.assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
namespace COMP3B.assignment_5.Controllers
{ 
    [ApiController]
     [Route("api/[controller]")]

    public class LibraryController : Controller
    {
        
        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks()
        {
            
            return Ok(LibraryData.Books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = LibraryData.Books.Find(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            
            return Ok(book);
        }

    }
}
