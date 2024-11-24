using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppBooks.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string? Name { get; set; }
    }
}
