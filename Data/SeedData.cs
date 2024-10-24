using BlazorWebAppBooks.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorWebAppBooks.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BlazorWebAppBooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BlazorWebAppBooksContext>>());

            if (context?.Book == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppBookContext or Book DbSet");
            }

            context.Database.EnsureCreated();

            if (context.Book.Any())
            {
                return;
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "Twilight",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2005, 10, 5),
                    Genre = "Romance",

                },
                new Book
                {
                    Title = "New Moon",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2006, 8, 21),
                    Genre = "Romance",

                }
                ,
                new Book
                {
                    Title = "Eclipse",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2007, 8, 7),
                    Genre = "Romance",
                }
                ,
                new Book
                {
                    Title = "Breaking Dawn",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2008, 8, 2),
                    Genre = "Romance",
                });
            context.SaveChanges();
        }
    }
}
