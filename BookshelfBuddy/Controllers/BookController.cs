using BookshelfBuddy.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookshelfBuddy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> books = new List<Book>
            {
                new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
                new Book { Id = 2, Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien" },
                new Book { Id = 3, Title = "The Two Towers", Author = "J.R.R. Tolkien" },
                new Book { Id = 4, Title = "The Return of the King", Author = "J.R.R. Tolkien" }
            };


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound("Book not found!");
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddBook(Book book)
        {
            books.Add(book);
            return Ok(books);
        }

        [HttpPut]
        public async Task<ActionResult<List<Book>>> UpdateBook(Book book)
        {
            var bookToUpdate = books.FirstOrDefault(b => b.Id == book.Id);
            if (bookToUpdate == null)
            {
                return NotFound("Book not found!");
            }
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Genre = book.Genre;
            bookToUpdate.Description = book.Description;
            return Ok(books);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Book>>> DeleteBook(int id)
        {
            var bookToDelete = books.FirstOrDefault(b => b.Id == id);
            if (bookToDelete == null)
            {
                return NotFound("Book not found!");
            }
            books.Remove(bookToDelete);
            return Ok(books);
        }
    }
}
