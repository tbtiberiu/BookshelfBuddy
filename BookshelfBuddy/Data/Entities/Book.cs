using System.Diagnostics.CodeAnalysis;

namespace BookshelfBuddy.Data.Entities
{
    public class Book
    {
        [NotNull]
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ShelfId { get; set; } = string.Empty;
        public Shelf? Shelf { get; set; } = null;
    }
}
