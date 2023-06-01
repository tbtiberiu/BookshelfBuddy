using BookshelfBuddy.Services.Dtos;

namespace BookshelfBuddy.Services.Interfaces
{
    public interface IShelfService
    {
        List<ShelfDto> GetAllShelves();
        ShelfDto GetShelfById(Guid id);
        void AddShelf(ShelfDto shelfDto);
        void UpdateShelf(Guid id, ShelfDto shelfDto);
        void DeleteShelf(Guid id);
    }

}
