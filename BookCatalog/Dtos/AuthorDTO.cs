using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public class AuthorDTO
    {   
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string NameAuthor { get; set; }
    }
}
