using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Models
{
    public class Author
    {   
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NameAuthor { get; set; }
    }
}
