using BlazorWebAppBooks.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAppBooks.Components
{
    public static class ButtonRoutes
    {
        public static void Delete(Book book, NavigationManager navman)
        {
            navman.NavigateTo($"books/delete?id={book.Id}");
        }

        public static void Edit(Book book, NavigationManager navman)
        {
            navman.NavigateTo($"books/edit?id={book.Id}");
        }
        public static void Details(Book book, NavigationManager navman)
        {
            navman.NavigateTo($"books/details?id={book.Id}");
        }

        public static void Back(NavigationManager navman)
        {
            navman.NavigateTo($"books/");
        }

        //BookRoutes
        public static void BackBook(NavigationManager navman)
        {
            navman.NavigateTo($"books/");
        }
        public static void CreateBook(NavigationManager navman)
        {
            navman.NavigateTo($"books/create");
        }
        public static void DeleteBook(Book book, NavigationManager navman)
        {
            navman.NavigateTo($"books/delete?id={book.Id}");
        }
        public static void DetailsBook(Book book, NavigationManager navman)
        {
            navman.NavigateTo($"books/details?id={book.Id}");
        }
        public static void EditBook(Book book, NavigationManager navman)
        {
            navman.NavigateTo($"books/edit?id={book.Id}");
        }

        //GenreRoutes
        public static void BackGenre(NavigationManager navman)
        {
            navman.NavigateTo($"genres/");
        }
        public static void CreateGenre(NavigationManager navman)
        {
            navman.NavigateTo($"genres/create");
        }
        public static void DeleteGenre(Genre genre, NavigationManager navman)
        {
            navman.NavigateTo($"genres/delete?id={genre.Id}");
        }
        public static void DetailsGenre(Genre genre, NavigationManager navman)
        {
            navman.NavigateTo($"genres/details?id={genre.Id}");
        }
        public static void EditGenre(Genre genre, NavigationManager navman)
        {
            navman.NavigateTo($"genres/edit?id={genre.Id}");
        }
    }
}
