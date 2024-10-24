using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppBooks.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string? Title { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string? Author { get; set; }

        public DateOnly ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
    }
}
