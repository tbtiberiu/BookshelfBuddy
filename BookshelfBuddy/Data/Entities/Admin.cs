using System.Diagnostics.CodeAnalysis;

namespace BookshelfBuddy.Data.Entities
{
    public class Admin
    {
        [NotNull]
        public Guid Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; } = null;
    }
}
