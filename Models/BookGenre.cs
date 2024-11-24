namespace BlazorWebAppBooks.Models
{
    public class BookGenre
    {
        public int Id { get; set; }
        public Genre? Genre { get; set; }
        public Book? Book { get; set; }
    }
}