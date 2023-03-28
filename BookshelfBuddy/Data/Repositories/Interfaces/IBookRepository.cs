using BookshelfBuddy.Data.Entities;

namespace BookshelfBuddy.Data.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }

}
