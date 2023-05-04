using System.Diagnostics.CodeAnalysis;

namespace BookshelfBuddy.Data.Entities
{
    public class Shelf
    {
        [NotNull]
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Book> Books { get; set; } = new List<Book>();
        public string ShelfOwnerId { get; set; } = string.Empty;
        public ShelfOwner? ShelfOwner { get; set; } = null;
    }
}
