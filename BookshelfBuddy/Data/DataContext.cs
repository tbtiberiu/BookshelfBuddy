using BookshelfBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookshelfBuddy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
