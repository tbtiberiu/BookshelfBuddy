using BookshelfBuddy.Data.Entities;
using BookshelfBuddy.Data.Repositories.Interfaces;

namespace BookshelfBuddy.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(Guid id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            var bookToUpdate = _context.Books.FirstOrDefault(b => b.Id == book.Id);
            if (bookToUpdate != null)
            {
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Genre = book.Genre;
                bookToUpdate.Description = book.Description;

                _context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            var bookToDelete = _context.Books.FirstOrDefault(b => b.Id == id);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }
    }
}
