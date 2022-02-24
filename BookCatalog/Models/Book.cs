using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models
{
    public class Book
    {   
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }
        public BookCategory Category { get; set; }

        public List<Author> Authors { get; set; }

        public Book()
        {
            Category = new BookCategory();
            Authors = new List<Author>();
        }
    }
}
