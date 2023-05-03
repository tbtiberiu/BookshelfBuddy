namespace BookshelfBuddy.Data.Entities
{
    public class ShelfOwner
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; } = null;
        public List<Shelf> Shelves { get; set; } = new List<Shelf>();
    }
}
