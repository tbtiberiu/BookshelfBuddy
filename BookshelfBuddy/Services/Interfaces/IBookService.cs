using BookshelfBuddy.Services.Dtos;

namespace BookshelfBuddy.Services.Interfaces
{
    public interface IBookService
    {
        List<BookDto> GetAllBooks();
        BookDto GetBookById(Guid id);
        void AddBook(BookDto bookDto);
        void UpdateBook(Guid id, BookDto bookDto);
        void DeleteBook(Guid id);
    }

}
