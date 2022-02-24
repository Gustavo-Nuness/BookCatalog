using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public class CreateOrUpdateAuthorDTO
    {
        [Required]
        public string NameAuthor { get; set; }
    }
}
