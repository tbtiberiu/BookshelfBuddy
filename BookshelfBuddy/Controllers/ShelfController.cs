using BookshelfBuddy.Services;
using BookshelfBuddy.Services.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BookshelfBuddy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : ControllerBase
    {
        private readonly ShelfService _service;

        public ShelfController(ShelfService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ShelfDto>> Get()
        {
            var shelfDtos = _service.GetAllShelves();
            return Ok(shelfDtos);
        }

        [HttpGet("{id}")]
        public ActionResult<ShelfDto> Get(Guid id)
        {
            var shelvesDto = _service.GetShelfById(id);
            if (shelvesDto == null)
            {
                return NotFound("Shelf not found!");
            }
            return Ok(shelvesDto);
        }

        [HttpPost]
        public ActionResult AddShelf(ShelfDto shelfDto)
        {
            _service.AddShelf(shelfDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateShelf(Guid id, ShelfDto shelfDto)
        {
            _service.UpdateShelf(id, shelfDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteShelf(Guid id)
        {
            _service.DeleteShelf(id);
            return Ok();
        }
    }
}
