using BookshelfBuddy.Data.Entities;

namespace BookshelfBuddy.Data.Repositories.Interfaces
{
    public interface IShelfRepository
    {
        List<Shelf> GetAll();
        Shelf GetById(Guid id);
        void Add(Shelf book);
        void Update(Shelf book);
        void Delete(Guid id);
    }
}
