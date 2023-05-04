using BookshelfBuddy.Data.Entities;

namespace BookshelfBuddy.Data.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(Guid id);
        void Add(Book book);
        void Update(Book book);
        void Delete(Guid id);
    }
}
