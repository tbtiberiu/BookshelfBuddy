using BookshelfBuddy.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookshelfBuddy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ShelvesController : ControllerBase
    {
        private readonly ShelfService _shelfService;

        public ShelvesController(ShelfService shelfService)
        {
            _shelfService = shelfService;
        }
    }
}
