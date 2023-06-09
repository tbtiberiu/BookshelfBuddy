using BookshelfBuddy.Data;

namespace BookshelfBuddy.Services
{
    public class ShelfService
    {
        private readonly UnitOfWork _unitOfWork;

        public ShelfService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
