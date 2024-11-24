using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppBooks.Data
{
    public class BlazorWebAppBooksContext : DbContext
    {
        public BlazorWebAppBooksContext(DbContextOptions<BlazorWebAppBooksContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppBooks.Models.Genre> Genre { get; set; } = default!;
        public DbSet<BlazorWebAppBooks.Models.Book> Book { get; set; } = default!;
        public DbSet<BlazorWebAppBooks.Models.BookGenre> BookGenre { get; set; } = default!;
    }
}
