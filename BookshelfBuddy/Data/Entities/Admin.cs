using System.Diagnostics.CodeAnalysis;

namespace BookshelfBuddy.Data.Entities
{
    public class Admin
    {
        [NotNull]
        public Guid Id { get; set; }
        public Guid UserId { get; set; } = Guid.Empty;
        public User? User { get; set; } = null;
    }
}
