using BookshelfBuddy.Data.Entities;
using BookshelfBuddy.Data.Repositories;
using BookshelfBuddy.Services.Dtos;
using BookshelfBuddy.Services.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookshelfBuddy.Services
{
    public class ShelfService : IShelfService
    {
        private readonly ShelfRepository _repository;

        public ShelfService(ShelfRepository repository)
        {
            _repository = repository;
        }

        public List<ShelfDto> GetAllShelves()
        {
            var shelves = _repository.GetAll();
            var shelfDtos = new List<ShelfDto>();
            foreach (var shelf in shelves)
            {
                shelfDtos.Add(new ShelfDto
                {
                    Id = shelf.Id,
                    Title = shelf.Title,
                    Description = shelf.Description,
                    Books = shelf.Books,
                    ShelfOwnerId = shelf.ShelfOwnerId,
                    ShelfOwner = shelf.ShelfOwner
                });
            }
            return shelfDtos;
        }

        public ShelfDto GetShelfById(Guid id)
        {
            var shelf = _repository.GetById(id);
            if (shelf == null)
            {
                return null;
            }
            var shelfDto = new ShelfDto
            {
                Id = shelf.Id,
                Title = shelf.Title,
                Description = shelf.Description,
                Books = shelf.Books,
                ShelfOwnerId = shelf.ShelfOwnerId,
                ShelfOwner = shelf.ShelfOwner
            };
            return shelfDto;
        }

        public void AddShelf(ShelfDto shelfDto)
        {
            var shelf = new Shelf
            {
                Id = shelfDto.Id,
                Title = shelfDto.Title,
                Description = shelfDto.Description,
                Books = shelfDto.Books,
                ShelfOwnerId = shelfDto.ShelfOwnerId,
                ShelfOwner = shelfDto.ShelfOwner
            };
            _repository.Add(shelf);
        }

        public void UpdateShelf(Guid id, ShelfDto shelfDto)
        {
            var shelf = _repository.GetById(id);
            if (shelf != null)
            {
                shelf.Id = shelfDto.Id;
                shelf.Title = shelfDto.Title;
                shelf.Description = shelfDto.Description;
                shelf.Books = shelfDto.Books;
                shelf.ShelfOwnerId = shelfDto.ShelfOwnerId;
                shelf.ShelfOwner = shelfDto.ShelfOwner;
                _repository.Update(shelf);
            }
        }

        public void DeleteShelf(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
