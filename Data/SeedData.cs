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
            context.Genre.AddRange(
                new Genre
                {
                    Name = "Romance",
                },
                new Genre
                {
                    Name = "Fantasy",
                });

            context.Book.AddRange(
                new Book
                {
                    Title = "Twilight",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2005, 10, 5),
                },
                new Book
                {
                    Title = "New Moon",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2006, 8, 21),


                }
                ,
                new Book
                {
                    Title = "Eclipse",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2007, 8, 7),

                }
                ,
                new Book
                {
                    Title = "Breaking Dawn",
                    Author = "Stephenie Meyer",
                    ReleaseDate = new DateOnly(2008, 8, 2),

                });
            context.SaveChanges();
        }
    }
}
