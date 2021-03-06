using BookCatalog.Models;
using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public record BookDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }
        [Required]
        public BookCategory Category { get; set; }
        [Required]
        public List<Author> Authors { get; set; }


        public BookDTO()
        {
            Category = new BookCategory();
            Authors = new List<Author>();
        }
    }
}
