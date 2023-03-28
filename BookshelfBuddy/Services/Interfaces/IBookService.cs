using BookshelfBuddy.Services.Dtos;

namespace BookshelfBuddy.Services.Interfaces
{
    public interface IBookService
    {
        List<BookDto> GetAllBooks();
        BookDto GetBookById(int id);
        void AddBook(BookDto bookDto);
        void UpdateBook(int id, BookDto bookDto);
        void DeleteBook(int id);
    }

}
