using BookshelfBuddy.Data.Entities;
using BookshelfBuddy.Data.Repositories;
using BookshelfBuddy.Services.Dtos;
using BookshelfBuddy.Services.Interfaces;

namespace BookshelfBuddy.Services
{
    public class BookService : IBookService
    {
        private readonly BookRepository _repository;

        public BookService(BookRepository repository)
        {
            _repository = repository;
        }

        public List<BookDto> GetAllBooks()
        {
            var books = _repository.GetAll();
            var bookDtos = new List<BookDto>();
            foreach (var book in books)
            {
                bookDtos.Add(new BookDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Genre = book.Genre,
                    Description = book.Description
                });
            }
            return bookDtos;
        }

        public BookDto GetBookById(int id)
        {
            var book = _repository.GetById(id);
            if (book == null)
            {
                return null;
            }
            var bookDto = new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Description = book.Description
            };
            return bookDto;
        }

        public void AddBook(BookDto bookDto)
        {
            var book = new Book
            {
                Title = bookDto.Title,
                Author = bookDto.Author,
                Genre = bookDto.Genre,
                Description = bookDto.Description
            };
            _repository.Add(book);
        }

        public void UpdateBook(int id, BookDto bookDto)
        {
            var book = _repository.GetById(id);
            if (book != null)
            {
                book.Title = bookDto.Title;
                book.Author = bookDto.Author;
                book.Genre = bookDto.Genre;
                book.Description = bookDto.Description;
                _repository.Update(book);
            }
        }

        public void DeleteBook(int id)
        {
            _repository.Delete(id);
        }
    }
}
