﻿using BlazorWebAppBooks.Models;
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

    }
}
