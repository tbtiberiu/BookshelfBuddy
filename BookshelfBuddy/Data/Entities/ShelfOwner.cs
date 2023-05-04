using System.Diagnostics.CodeAnalysis;

namespace BookshelfBuddy.Data.Entities
{
    public class ShelfOwner
    {
        [NotNull]
        public Guid Id { get; set; }
        public Guid UserId { get; set; } = Guid.Empty;
        public User? User { get; set; } = null;
        public List<Shelf> Shelves { get; set; } = new List<Shelf>();
    }
}
