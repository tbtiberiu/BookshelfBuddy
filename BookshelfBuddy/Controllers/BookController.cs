using BookshelfBuddy.Services;
using BookshelfBuddy.Services.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BookshelfBuddy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _service;

        public BookController(BookService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> Get()
        {
            var bookDtos = _service.GetAllBooks();
            return Ok(bookDtos);
        }

        [HttpGet("{id}")]
        public ActionResult<BookDto> Get(Guid id)
        {
            var bookDto = _service.GetBookById(id);
            if (bookDto == null)
            {
                return NotFound("Book not found!");
            }
            return Ok(bookDto);
        }

        [HttpPost]
        public ActionResult AddBook(BookDto bookDto)
        {
            _service.AddBook(bookDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBook(Guid id, BookDto bookDto)
        {
            _service.UpdateBook(id, bookDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBook(Guid id)
        {
            _service.DeleteBook(id);
            return Ok();
        }
    }
}
