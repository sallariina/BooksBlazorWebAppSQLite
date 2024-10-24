using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppBooks.Models;

namespace BlazorWebAppBooks.Data
{
    public class BlazorWebAppBooksContext : DbContext
    {
        public BlazorWebAppBooksContext (DbContextOptions<BlazorWebAppBooksContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppBooks.Models.Book> Book { get; set; } = default!;
    }
}
