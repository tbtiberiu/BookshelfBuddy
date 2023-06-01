using BookshelfBuddy.Data.Entities;
using BookshelfBuddy.Data.Repositories.Interfaces;

namespace BookshelfBuddy.Data.Repositories
{
    public class ShelfRepository : IShelfRepository
    {
        private readonly DataContext _context;

        public ShelfRepository(DataContext context)
        {
            _context = context;
        }

        public List<Shelf> GetAll()
        {
            return _context.Shelves.ToList();
        }

        public Shelf GetById(Guid id)
        {
            return _context.Shelves.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Shelf shelf)
        {
            _context.Shelves.Add(shelf);
            _context.SaveChanges();
        }

        public void Update(Shelf shelf)
        {
            var shelfToUpdate = _context.Shelves.FirstOrDefault(b => b.Id == shelf.Id);
            if (shelfToUpdate != null)
            {
                shelfToUpdate.Title = shelf.Title;
                shelfToUpdate.Description = shelf.Description;
                shelfToUpdate.Books = shelf.Books;
                shelfToUpdate.ShelfOwnerId = shelf.ShelfOwnerId;
                shelfToUpdate.ShelfOwner = shelf.ShelfOwner;

                _context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            var shelfToDelete = _context.Shelves.FirstOrDefault(b => b.Id == id);
            if (shelfToDelete != null)
            {
                _context.Shelves.Remove(shelfToDelete);
                _context.SaveChanges();
            }
        }
    }
}
