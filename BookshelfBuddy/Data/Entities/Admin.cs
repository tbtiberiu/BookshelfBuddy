namespace BookshelfBuddy.Data.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; } = null;
    }
}
