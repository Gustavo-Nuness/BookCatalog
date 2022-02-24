using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models
{
    public class Author
    {   
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string NameAuthor { get; set; }
    }
}
